function EnderecoSelecionado(selector) {
    /*Animacao*/
    var campoSeletor = $(selector);
    campoSeletor.toggleClass("ativado");
    $(".animacao-endereco").not(campoSeletor).removeClass("ativado");


    var dados = campoSeletor.find(".dados").text()
    var arrayDados = dados.split(/\s/);

}