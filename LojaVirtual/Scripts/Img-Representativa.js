function MostraImg(seletor) {
    var imagem = $(seletor).children(".img").text();
    var nome = $(seletor).children(".info-nome").text();
    var valor = $(seletor).children(".valor").text();
    var categoria = $(seletor).children(".categoria").text();

    $("#img-representativa").attr("src", "../img/" + imagem)
    $(".nome-representativo").text(nome)
    $(".valor-representativo").text("Valor: R$ " + valor)
    $(".categoria-representativo").text("Categoria: " + categoria)
}