function GravaPedido(total) {
    for (let i = 0; i < sessionStorage.length; i++) {
        var keys = sessionStorage.key(i);
        var produto = sessionStorage.getItem(keys);
        var produtoSplit = produto.split(",");

        if (keys != "Total" && keys != "clickcount" && keys != "IdProduto") {
            var id = produtoSplit[3];
            var valorTotal = $(total).text()
            $.post("http://localhost:61651/Pedido/Grava", { id: id, total: valorTotal })
                .fail(function () {
                    $(".msg-erro").toggle();
                    setTimeout(function () {
                        $(".msg-erro").toggle();
                    }, 2000);
                })
                .done(function () {
                    sessionStorage.clear()
                })
        }
    }
}