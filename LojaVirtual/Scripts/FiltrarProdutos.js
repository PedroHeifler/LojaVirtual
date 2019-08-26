function FiltrarProdutos(genero) {
    const generoCheck = $(genero).val()
    let campo = $(".filtro-produtos").children(".card-body").children("h5")

    var expressao = new RegExp(generoCheck, "i");

    for (var i = 0; i < campo.length; i++) {

        var a = $(".filtro-produtos")
        if (!expressao.test(campo[i])) {
            a.addClass("invisivel");
        } else {
            a.removeClass("invisivel");
        }
    }
}