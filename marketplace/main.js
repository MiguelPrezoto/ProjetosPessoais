// variaveis linhas produtos 
const linhasProdutos = document.querySelectorAll(".linhaProdutos");
const btnEsquerda = document.querySelectorAll(".seta.esquerda");
const btnDireita = document.querySelectorAll(".seta.direita");

const scrollPorClique = 250;

//popup login
const iconUsuario = document.getElementById('iconUser');
const loginPopup = document.getElementById('loginPopUp');
const fecharPopUpLogin = document.getElementById('fecharPopUpLogin');

//popup carrinho
const iconCarrinho = document.getElementById('iconCarrinho');
const carrinhoPopUp = document.getElementById('carrinhoPopUp');
const fecharPopUpCarrinho = document.getElementById('fecharPopUpCarrinho');

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



//abrir popup login
iconUsuario.addEventListener('click', () => {
    loginPopup.style.display = 'flex';
});

//fechar popup login
fecharPopUpLogin.addEventListener('click', () => {
    loginPopup.style.display = 'none';
    carrinhoPopUp.style.display = 'none';
});

//fechar o popup se o usuário clicar fora da div de conteúdo
window.addEventListener('click', (event) => {
    if (event.target === loginPopup || event.target === carrinhoPopUp) {
        loginPopup.style.display = 'none';
        carrinhoPopUp.style.display = 'none';
    }
});

//abrri popup carrinho
iconCarrinho.addEventListener('click', () => {
  carrinhoPopUp.style.display = 'flex';
});

fecharPopUpCarrinho.addEventListener('click', () => {
    loginPopup.style.display = 'none';
    carrinhoPopUp.style.display = 'none';
});