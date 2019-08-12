function PassarCarrinho(produto) {

    var produtos = sessionStorage.getItem("produto")
    
    if (produtos == null) {
        sessionStorage.setItem("produto"+ [i], produto);
    }

    if (produtos != null) {
        for (var i = 0; i < produtos.length + 1; i++) {
            sessionStorage.setItem("produto"+[i], produto);
        }
    }
}