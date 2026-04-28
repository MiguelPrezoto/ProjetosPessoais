const express = require("express");
const cors = require("cors");
const Database = require("better-sqlite3");
const fs = require("fs");
const path = require("path");
const crypto = require("crypto");

const app = express();
const PORT = 3000;

app.use(cors());
app.use(express.json());

const dbPath = path.join(__dirname, "marketplace.db");
const schemaPath = path.join(__dirname, "init.sql");
const db = new Database(dbPath);

db.pragma("foreign_keys = ON");

if (!fs.existsSync(schemaPath)) {
  throw new Error("Arquivo init.sql nao encontrado na pasta api.");
}

const schema = fs.readFileSync(schemaPath, "utf8");
db.exec(schema);

function hashSenha(senha) {
  return crypto.createHash("sha256").update(senha).digest("hex");
}

function getOrCreateCarrinho(usuarioId) {
  const carrinhoExistente = db
    .prepare("SELECT id FROM carrinhos WHERE usuario_id = ?")
    .get(usuarioId);

  if (carrinhoExistente) {
    return carrinhoExistente.id;
  }

  const insert = db
    .prepare("INSERT INTO carrinhos (usuario_id) VALUES (?)")
    .run(usuarioId);
  return insert.lastInsertRowid;
}

app.get("/api/health", (req, res) => {
  res.json({ ok: true });
});

app.post("/api/usuarios", (req, res) => {
  const { nome, email, senha } = req.body;

  if (!nome || !email || !senha) {
    return res
      .status(400)
      .json({ erro: "Campos obrigatorios: nome, email e senha." });
  }

  try {
    const senhaHash = hashSenha(senha);
    const result = db
      .prepare(
        "INSERT INTO usuarios (nome, email, senha_hash) VALUES (?, ?, ?)"
      )
      .run(nome, email, senhaHash);

    return res.status(201).json({
      id: result.lastInsertRowid,
      nome,
      email,
    });
  } catch (error) {
    if (String(error.message).includes("UNIQUE")) {
      return res.status(409).json({ erro: "Email ja cadastrado." });
    }
    return res.status(500).json({ erro: "Falha ao criar usuario." });
  }
});

app.get("/api/produtos", (req, res) => {
  const produtos = db
    .prepare("SELECT id, nome, preco, estoque FROM produtos ORDER BY id DESC")
    .all();
  res.json(produtos);
});

app.post("/api/produtos", (req, res) => {
  const { nome, preco, estoque } = req.body;

  if (!nome || preco === undefined) {
    return res
      .status(400)
      .json({ erro: "Campos obrigatorios: nome e preco." });
  }

  const precoNumero = Number(preco);
  const estoqueNumero = estoque === undefined ? 0 : Number(estoque);

  if (Number.isNaN(precoNumero) || Number.isNaN(estoqueNumero)) {
    return res.status(400).json({ erro: "preco/estoque invalidos." });
  }

  const result = db
    .prepare("INSERT INTO produtos (nome, preco, estoque) VALUES (?, ?, ?)")
    .run(nome, precoNumero, estoqueNumero);

  res.status(201).json({
    id: result.lastInsertRowid,
    nome,
    preco: precoNumero,
    estoque: estoqueNumero,
  });
});

app.post("/api/carrinho/:usuarioId/itens", (req, res) => {
  const usuarioId = Number(req.params.usuarioId);
  const { produtoId, quantidade } = req.body;

  const produtoIdNumero = Number(produtoId);
  const quantidadeNumero = quantidade === undefined ? 1 : Number(quantidade);

  if (!Number.isInteger(usuarioId) || usuarioId <= 0) {
    return res.status(400).json({ erro: "usuarioId invalido." });
  }
  if (!Number.isInteger(produtoIdNumero) || produtoIdNumero <= 0) {
    return res.status(400).json({ erro: "produtoId invalido." });
  }
  if (!Number.isInteger(quantidadeNumero) || quantidadeNumero <= 0) {
    return res.status(400).json({ erro: "quantidade invalida." });
  }

  const usuario = db
    .prepare("SELECT id FROM usuarios WHERE id = ?")
    .get(usuarioId);
  if (!usuario) {
    return res.status(404).json({ erro: "Usuario nao encontrado." });
  }

  const produto = db
    .prepare("SELECT id, estoque FROM produtos WHERE id = ?")
    .get(produtoIdNumero);
  if (!produto) {
    return res.status(404).json({ erro: "Produto nao encontrado." });
  }

  const carrinhoId = getOrCreateCarrinho(usuarioId);
  const item = db
    .prepare(
      "SELECT id, quantidade FROM carrinho_itens WHERE carrinho_id = ? AND produto_id = ?"
    )
    .get(carrinhoId, produtoIdNumero);

  if (item) {
    db.prepare("UPDATE carrinho_itens SET quantidade = ? WHERE id = ?").run(
      item.quantidade + quantidadeNumero,
      item.id
    );
  } else {
    db.prepare(
      "INSERT INTO carrinho_itens (carrinho_id, produto_id, quantidade) VALUES (?, ?, ?)"
    ).run(carrinhoId, produtoIdNumero, quantidadeNumero);
  }

  res.status(201).json({ mensagem: "Item adicionado ao carrinho." });
});

app.get("/api/carrinho/:usuarioId", (req, res) => {
  const usuarioId = Number(req.params.usuarioId);

  if (!Number.isInteger(usuarioId) || usuarioId <= 0) {
    return res.status(400).json({ erro: "usuarioId invalido." });
  }

  const usuario = db
    .prepare("SELECT id FROM usuarios WHERE id = ?")
    .get(usuarioId);
  if (!usuario) {
    return res.status(404).json({ erro: "Usuario nao encontrado." });
  }

  const carrinho = db
    .prepare("SELECT id, criado_em FROM carrinhos WHERE usuario_id = ?")
    .get(usuarioId);

  if (!carrinho) {
    return res.json({
      carrinhoId: null,
      usuarioId,
      itens: [],
      total: 0,
    });
  }

  const itens = db
    .prepare(
      `
      SELECT
        ci.id AS itemId,
        p.id AS produtoId,
        p.nome,
        p.preco,
        ci.quantidade,
        (p.preco * ci.quantidade) AS subtotal
      FROM carrinho_itens ci
      INNER JOIN produtos p ON p.id = ci.produto_id
      WHERE ci.carrinho_id = ?
      ORDER BY ci.id DESC
      `
    )
    .all(carrinho.id);

  const total = itens.reduce((acc, item) => acc + item.subtotal, 0);

  return res.json({
    carrinhoId: carrinho.id,
    usuarioId,
    criadoEm: carrinho.criado_em,
    itens,
    total,
  });
});

app.listen(PORT, () => {
  console.log(`API rodando em http://localhost:${PORT}`);
});
