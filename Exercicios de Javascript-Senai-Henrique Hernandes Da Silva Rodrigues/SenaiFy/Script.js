var botao = document.getElementById("botao");
var fundo = document.getElementById("fundo");
var fechar = document.getElementById("fechar");

botao.onclick = function() {
    fundo.classList.add("visivel");
}

fechar.onclick = function() {
    fundo.classList.remove("visivel");
}