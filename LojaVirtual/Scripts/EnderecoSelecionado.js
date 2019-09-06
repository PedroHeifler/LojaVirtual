Continuar(false)

function EnderecoSelecionado(selector) {

    var endereco = $(".animacao-endereco")

    for (var i = 0; i < endereco.length; i++) {

        if (endereco.hasClass("ativado")) {
            Continuar(true)
        } else {
            Continuar(false)
        }
    }

    Animacao($(selector))
    
}

function Continuar(status) {
    $(".continuar").attr("disabled", status)
}

function Animacao(selector) {
    selector.toggleClass("ativado");
    endereco.not(selector).removeClass("ativado");
}