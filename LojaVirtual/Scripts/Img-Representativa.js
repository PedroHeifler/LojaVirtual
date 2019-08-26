function MostraImg(seletor) {
    var imagem = $(seletor).children(".img").text();
    var nome = $(seletor).children(".info-nome").text();

    $("#img-representativa").attr("src", "../img/" + imagem)
    $(".nome-representativo").text(nome)
}