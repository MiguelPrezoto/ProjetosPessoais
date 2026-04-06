const alvo = document.getElementById("linhaProdutos");

const btnEsquerda = document.querySelector(".esquerda");
const btnDireita = document.querySelector(".direita");

const scrollPorClique = 250;

btnDireita.addEventListener("click", () => {
  alvo.scrollBy({
    left: scrollPorClique,
    behavior: "smooth",
  });
});

btnEsquerda.addEventListener("click", () => {
  alvo.scrollBy({
    left: scrollPorClique - scrollPorClique * 2,
    behavior: "smooth",
  });
});


