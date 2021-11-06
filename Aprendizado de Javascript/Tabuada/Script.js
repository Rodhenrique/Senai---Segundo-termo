function tabuada() {
    var tabo = document.getElementById("tabu").value;
    var com = document.getElementById("com").value;
    var campo = document.getElementById("campos");
    var opt = document.getElementById("opa");

    opt.innerHTML = '';
    let cam = com;
    if (cam == 0) {
        cam = 10
    }
    for (let index = 1; index <= cam; index++) {
        if (tabo <= 0) {
            window.alert("Verifique os campos")
        } else {
            let item = document.createElement("option");
            item.innerText = `${tabo} X  ${index} = ${(tabo*index)}`;
            opt.appendChild(item)
        }
    }

}