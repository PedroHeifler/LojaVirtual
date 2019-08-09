function MostraImg(seletor) {
    var imagem = $(seletor).children(".img").text();

    $("#img-representativa").attr("src", "../img/"+imagem)
}