function capturar() {
    var Sexo = document.querySelector("input[name='ruw']:checked").value;
    var idade = document.getElementById("idade").value;
    var imagem = document.getElementById("imagem");
    var cont = document.getElementById("container");


    var resul = 2020 - idade;
    if (idade > 2020 || idade < 0) {
        alert("Verifique os campos")
        imagem.src = "IMG/Interrogação.png"
        cont.style.backgroundColor = "#ffff";
    } else {
        var ide = document.getElementById("inscrita");
        if (Sexo == "Masculino") {
            cont.style.backgroundColor = "#3085C2";
            if (resul > 0 && resul < 11) {
                ide.innerText = "Criança sua idade é " + resul + " anos"
                imagem.src = "IMG/Criança.jpg"
            } else if (resul > 11 && resul < 21) {
                ide.innerText = "adolescente sua idade é " + resul + " anos"
                imagem.src = "IMG/Adolescente-Mas.jpg"
            } else if (resul >= 21 && resul < 55) {
                ide.innerText = "Adulto sua idade é " + resul + " anos"
                imagem.src = "IMG/Adulto-Mas.jpg"
            } else {
                ide.innerText = "Idoso sua idade é " + resul + " anos"
                imagem.src = "IMG/Idoso-Mas.jpg"
            }
        } else if (Sexo == "Feminino") {
            cont.style.backgroundColor = "#B630C2";
            if (resul > 0 && resul < 11) {
                ide.innerText = "Criança sua idade é " + resul + " anos"
                imagem.src = "IMG/Criança-M.jpg"
            } else if (resul > 11 && resul < 21) {
                ide.innerText = "adolescente sua idade é " + resul + " anos"
                imagem.src = "IMG/Adolescente-M.jpg"
            } else if (resul >= 21 && resul < 55) {
                ide.innerText = "Adulto sua idade é " + resul + " anos"
                imagem.src = "IMG/Aulto-M.jpg"
            } else {
                ide.innerText = "Idoso sua idade é " + resul + " anos"
                imagem.src = "IMG/Idoso-M.jpg"
            }
        }
    }
}