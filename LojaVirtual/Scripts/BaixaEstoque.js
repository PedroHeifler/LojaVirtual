function BaixaEstoque() {
    for (let i = 0; i < sessionStorage.length; i++) {
        var keys = sessionStorage.key(i);
        var produto = sessionStorage.getItem(keys);
        var produtoSplit = produto.split(",");

        if (keys != "Total" && keys != "clickcount" && keys != "IdProduto") {
            var id = produtoSplit[3];

            /*$.post("http://localhost:61651/AdminProduto/Excluir", { id: id })
                .fail(function () {
                    $(".msg-erro").toggle();
                    setTimeout(function () {
                        $(".msg-erro").toggle();
                    }, 2000);
                })*/
        }
    }
}