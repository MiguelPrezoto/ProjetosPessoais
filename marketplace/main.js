// variaveis linhas produtos 
const linhasProdutos = document.querySelectorAll(".linhaProdutos");
const btnEsquerda = document.querySelectorAll(".seta.esquerda");
const btnDireita = document.querySelectorAll(".seta.direita");

const scrollPorClique = 250;

// Navegação à direita
btnDireita.forEach((btn, index) => {
  btn.addEventListener("click", () => {
    linhasProdutos[index].scrollBy({
      left: scrollPorClique,
      behavior: "smooth",
    });
  });
});

// Navegação à esquerda
btnEsquerda.forEach((btn, index) => {
  btn.addEventListener("click", () => {
    linhasProdutos[index].scrollBy({
      left: -scrollPorClique,
      behavior: "smooth",
    });
  });
});