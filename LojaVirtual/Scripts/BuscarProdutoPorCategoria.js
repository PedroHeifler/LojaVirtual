function BuscarProdutoPorCategoria(id) {
    $.post('http://localhost:61651/produtos/BuscarProdutoPorIdCategoria', { id: id })
        .done(function (produtos) {

            var idproduto = $('.id-produto');

            for (var i = 0; i < idproduto.length; i++) {
                $(idproduto[i]).parent().fadeOut()
                for (var u = 0; u < produtos.length; u++) {

                    if (produtos[u].IdProduto == idproduto[i].innerText) {
                        $(idproduto[i]).parent().fadeIn();
                    }
                }

            }
        })
}

function MostrarTodos() {
    var idproduto = $('.id-produto');

    for (var i = 0; i < idproduto.length; i++) {
        $(idproduto[i]).parent().fadeIn()
    }
}