$(".continuar").attr("disabled", true)
function EnderecoSelecionado(selector) {
    var endereco = $(".animacao-endereco")
    for (var i = 0; i < endereco.length; i++) {

        if (!endereco.hasClass("ativado")) {
            $(".continuar").attr("disabled", false)
            console.log("asdasd")
        } else {
            $(".continuar").attr("disabled", true)
        }
    }

    /*Animacao*/
    var campoSeletor = $(selector);
    campoSeletor.toggleClass("ativado");
    endereco.not(campoSeletor).removeClass("ativado");


    var dados = campoSeletor.find(".dados").text()
    var arrayDados = dados.split(/\s/);

}