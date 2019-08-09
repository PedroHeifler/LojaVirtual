function PassarCarrinho(nome) {
    for (var i = 0; i < nome.length; i++) {
        sessionStorage.setItem("nomes", nome[i]);
    }
    
}