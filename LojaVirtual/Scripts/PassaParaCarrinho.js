function PassarCarrinho(produto) {
 
    if (produto) {

        if (sessionStorage.clickcount) {
            var contador = sessionStorage.clickcount = Number(sessionStorage.clickcount) + 1;
        } else {
            contador = sessionStorage.clickcount = 0;
        }

        sessionStorage.setItem("produto" + [contador], produto);
    }
}