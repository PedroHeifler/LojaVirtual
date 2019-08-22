function ativar(seletor) {
    /*Animacao*/
    var campoSeletor = $(seletor);
    campoSeletor.toggleClass("ativado");
    $(".animacao-pagamento").not(campoSeletor).removeClass("ativado");
}