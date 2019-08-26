let total = 0.0;

for (let i = 0; i < sessionStorage.length; i++) {
    var keys = sessionStorage.key(i);
    var produto = sessionStorage.getItem(keys);
    var produtoSplit = produto.split(",")
    if (keys != "Total" && keys != "clickcount" && keys != "IdProduto") {

        var carrinho = $(".carrinho");
        var tr = document.createElement("tr");
        carrinho.append(tr)

        /*---Imagem---*/
        var img = document.createElement("td");
        var imagem = document.createElement("img");
        imagem.setAttribute("src", "/img/" + produtoSplit[0])
        imagem.style.width = "100px";
        img.append(imagem)
        tr.append(img);


        /*---Nome---*/
        var nome = document.createElement("td");
        nome.textContent = produtoSplit[1]
        nome.classList.add("align-middle")
        nome.classList.add("nome-carrinho")
        tr.append(nome);

        /*---Valor---*/
        var valor = document.createElement("td");
        valor.textContent = produtoSplit[2]
        valor.classList.add("align-middle")
        tr.append(valor)

        /*---Botao---*/
        var acao = document.createElement("td")
        acao.classList.add("align-middle")
        var botaoExcluir = document.createElement("button");
        var botao = document.createElement("td");
        botaoExcluir.classList.add("btn");
        botaoExcluir.classList.add("btn-danger");
        botaoExcluir.setAttribute("onclick", 'ExcluiDoCarrinho(this.parentElement.parentElement)')
        acao.append(botaoExcluir)
        tr.append(acao)

        /*---icone---*/
        var icone = document.createElement('i')
        icone.classList.add("fas")
        icone.classList.add("fa-trash-alt")
        botaoExcluir.append(icone)

        var split = produto.split(",")

        total = total + parseFloat(split[2])

        $(".total").text("Total: R$" + total);

        sessionStorage.setItem('Total', total);
    }
}

function ExcluiDoCarrinho(key) {
    var nome = $(key).children(".nome-carrinho").text()
        for (let i = 0; i < sessionStorage.length; i++) {
            var keys = sessionStorage.key(i);
            var produto = sessionStorage.getItem(keys)
            var produtoSplit = produto.split(",")

            if (nome == produtoSplit[1]) {
                var id = keys
                $(key).fadeOut("slow", function () {
                    sessionStorage.removeItem(id)
                });
        }
    }
}