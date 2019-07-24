function Editar(seletor) {
    var id = $(seletor).children("th").text();
    $("form input[name=IdProduto]").val(id)

    var sku = $(seletor).children(".info-sku").text();
    $("form input[name=SKU]").val(sku)

    var nome = $(seletor).children(".info-nome").text();
    $("form input[name=Nome]").val(nome)

    var imagem = $(seletor).children(".info-imagem").text();
    $("form input[name=Imagem]").val(imagem)

}