// variaveis linhas produtos 
const linhasProdutos = document.querySelectorAll(".linhaProdutos");
const btnEsquerda = document.querySelectorAll(".seta.esquerda");
const btnDireita = document.querySelectorAll(".seta.direita");

const scrollPorClique = 250;

//popup login
const iconUsuario = document.getElementById('iconUser');
const loginPopup = document.getElementById('loginPopUp');
const fecharPopUp = document.getElementById('fecharPopUp');

// nav direita
btnDireita.forEach((btn, index) => {
  btn.addEventListener("click", () => {
    linhasProdutos[index].scrollBy({
      left: scrollPorClique,
      behavior: "smooth",
    });
  });
});

// nav esquerda
btnEsquerda.forEach((btn, index) => {
  btn.addEventListener("click", () => {
    linhasProdutos[index].scrollBy({
      left: -scrollPorClique,
      behavior: "smooth",
    });
  });
});



// abrir popup
iconUsuario.addEventListener('click', () => {
    loginPopup.style.display = 'flex'; // Exibe o popup
});

// fechar popup
fecharPopUp.addEventListener('click', () => {
    loginPopup.style.display = 'none'; // Esconde o popup
});

// Fechar o popup se o usuário clicar fora da caixa de conteúdo
window.addEventListener('click', (event) => {
    if (event.target === loginPopup) {
        loginPopup.style.display = 'none'; // Esconde o popup se clicar fora dele
    }
});