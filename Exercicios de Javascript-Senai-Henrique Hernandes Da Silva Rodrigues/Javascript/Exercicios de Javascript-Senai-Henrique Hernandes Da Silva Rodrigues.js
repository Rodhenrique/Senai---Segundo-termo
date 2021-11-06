var Pessoa = {
    Nome: "Henrique",
    Sobrenome: "Hernandes",
    Genero: "Masculino",
    Idade: 17,
    Altura: 1.70,
    Peso: "57",
    Andando: false,
    CaminhouQuantosMetros: 0,
    FazerAniversario: function() {
        this.Idade += 1;
    },
    Andar: function(metros) {
        this.Andando = true
        this.CaminhouQuantosMetros += metros
    },
    Parar: function() {
        this.Andando = false
    }
}

function NomeCompleto() {
    var frase = `Olá! Meu nome é ${Pessoa.Nome} ${Pessoa.Sobrenome}`
    return frase
}

function MostrarIdade() {
    var frase = `Olá! Eu tenho ${Pessoa.Idade} anos!`
    return frase
}

function MostrarPeso() {
    var frase = `Eu peso ${Pessoa.Peso}Kg.`
    return frase
}

function MostrarAltura() {
    var frase = `Minha altura ${Pessoa.Altura}m.`
    return frase
}

function Apresentacao() {
    var letra = "o"
    if (Pessoa.Genero.toLowerCase() == "feminino") {
        letra = "a"
    }
    var line = "anos"
    if (Pessoa.Idade == 1) {
        line = "ano"
    }
    var run = " metros"

    var me = ""
    var mod = Pessoa.CaminhouQuantosMetros
    if (Pessoa.CaminhouQuantosMetros == 1) {
        run = " metro"
    } else if (Pessoa.CaminhouQuantosMetros >= 1000) {
        run = "Km"
        var mani = `${Pessoa.CaminhouQuantosMetros}`
        var num = mani.length - 3
        mod = mani.substring(-3, num)
        if (mani.substr(-3, 1) != 0) {
            me = `,${mani.substr(-3, 1)}`
        }
        Pessoa.CaminhouQuantosMetros = mod
    }
    var frase = `Olá, eu sou ${letra} ${Pessoa.Nome}, tenho ${Pessoa.Idade} ${line},
    minha altura${Pessoa.Altura},meu peso é ${Pessoa.Peso}Kg
     e so hoje, eu já caminhei ${mod}${me}${run}!`
    return frase
}


console.log(Pessoa)
console.log(Apresentacao())
console.log(MostrarAltura())
console.log(MostrarIdade())
console.log(MostrarAltura())
console.log(MostrarPeso())
console.log(NomeCompleto())

function MostrarObjeto() {
    var example = document.getElementById("example")
    fecha()
    example.style.display = "block"
    example.innerHTML = ""
    var outro = ["Nome", "Sobrenome", "Genero", "Idade", "Altura", "Peso", "CaminhouQuantosMetros", "Andando"]

    for (let index = 0; index < outro.length; index++) {
        let item = document.createElement("p");
        var frase = ""
        if (Pessoa[outro[index]] == Pessoa.Peso) {
            frase = "Kg"
        } else if (Pessoa[outro[index]] == Pessoa.Idade) {
            if (Pessoa.Idade == 1) {
                frase = " Ano"
            } else {
                frase = " Anos"
            }
        }

        item.innerText = `${outro[index]}: ${Pessoa[outro[index]]}${frase}`;
        example.appendChild(item)
    }
}

function Create() {
    var doc = document.getElementById("create")
    fecha()
    doc.style.display = "block"
}

function adiciona() {
    var p1 = document.getElementById("p1").value
    var p2 = document.getElementById("p2").value
    var p3 = document.getElementById("p3").value
    var p4 = document.getElementById("p4").value
    var p5 = document.getElementById("p5").value
    var p6 = document.querySelector("input[name='run']:checked").value

    Pessoa.Nome = p1
    Pessoa.Sobrenome = p2
    Pessoa.Idade = p3
    Pessoa.Altura = p4
    Pessoa.Peso = p5
    Pessoa.Genero = p6

}


function ExibirName() {
    var doc = document.getElementById("mostraNome")
    fecha()
    doc.style.display = "block"
    doc.innerHTML = ""
    let item = document.createElement("p");
    item.innerText = NomeCompleto();
    doc.appendChild(item)

}

function ExibirIdade() {
    var doc = document.getElementById("mostraIdade")
    fecha()
    doc.style.display = "block"
    doc.innerHTML = ""
    let item = document.createElement("p");
    item.innerText = MostrarIdade();
    doc.appendChild(item)
}

function ExibirPeso() {
    var doc = document.getElementById("mostraPeso")
    fecha()
    doc.style.display = "block"
    doc.innerHTML = ""
    let item = document.createElement("p");
    item.innerText = MostrarPeso();
    doc.appendChild(item)
}

function ExibirAltura() {
    var doc = document.getElementById("mostraAltura")
    fecha()
    doc.style.display = "block"
    doc.innerHTML = ""
    let item = document.createElement("p");
    item.innerText = MostrarAltura();
    doc.appendChild(item)
}

function Exibirapresentacao() {
    var doc = document.getElementById("apresentacao")
    fecha()
    doc.style.display = "block"
    doc.innerHTML = ""
    let item = document.createElement("p");
    item.innerText = Apresentacao();
    doc.appendChild(item)
}

function caminhar() {
    var doc = document.getElementById("caminhar")
    fecha()

    var but = document.getElementById("botao")
    var panel = document.getElementById("certo")
    var metros = document.getElementById("running").value
    panel.style.display = "flex"

    but.addEventListener('click', function() {
        panel.style.display = "none"
        doc.style.display = "block"

        var e = metros
        Pessoa.Andar(e)
        let image = new Image();
        image.src = "sheet.png";
        let counter = 0,
            frame_width = 74.6,
            frame_height = 182;
        image.onload = function() {
            let canvas = document.getElementById("myCanvas");
            let context = canvas.getContext("2d");
            window.requestAnimationFrame(animate);

            function animate() {
                context.clearRect(0, 0, canvas.width, canvas.height);
                let frame = Math.floor(counter % 3.6);
                context.drawImage(image, frame * frame_width, 0, frame_width, frame_height, counter * 10, 0, frame_width, frame_height);
                counter = counter + .15;
                if (counter > 83) counter = 83
                window.requestAnimationFrame(animate);
            }
        }
    })
}

function parar() {
    var doc = document.getElementById("parar")
    fecha()
    doc.style.display = "block"

    let image = new Image();
    image.src = "sheet.png";
    let counter = 0,
        frame_width = 74.6,
        frame_height = 182;
    image.onload = function() {
        let canvas = document.getElementById("ruben");
        let context = canvas.getContext("2d");
        window.requestAnimationFrame(animate);

        function animate() {
            context.clearRect(0, 0, canvas.width, canvas.height);
            let frame = Math.floor(counter % 3.6);
            context.drawImage(image, frame * frame_width, 0, frame_width, frame_height, counter * 10, 0, frame_width, frame_height);
            counter = counter + .30;
            if (counter > 37) counter = 37
            window.requestAnimationFrame(animate);
        }
    }
}


function fecha() {
    var fec = document.getElementsByClassName("close")
    for (let index = 0; index < fec.length; index++) {
        fec[index].style.display = "none"
    }
}