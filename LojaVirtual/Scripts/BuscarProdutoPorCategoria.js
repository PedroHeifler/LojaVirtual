function BuscarProdutoPorCategoria(id) {
    $.post('http://localhost:61651/Produtos/BuscarProdutoPorIdCategoria', { id: id }, atualiza);

    function atualiza(data) {
        console.log(data)
    }
}

/*.done(function (produtos) {
    var idproduto = $('.id-produto');

    for (var i = 0; i < idproduto.length; i++) {

        if (produtos != null) {

            if (produtos.IdProduto == idproduto[i].innerText) {
                $(idproduto[i]).parent();
            }
            if (produtos.IdProduto != idproduto[i].innerText) {
                ;
                $(idproduto[i]).parent().fadeToggle()
            }
        }
    }
})
    .fail(function (produtos) {
        console.log("fail")
    })*/