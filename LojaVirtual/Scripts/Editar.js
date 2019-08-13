function Editar(seletor) {
    var campoTable = $(seletor).children()
    for (var i = 0; i < campoTable.length -1; i++) {
        var valor = $(campoTable).get(i).textContent;
        var input = $("form input, input[type='date'], textarea, select").get(i)
        $(input).val(valor)

    }
    var id = $(campoTable).get(0).textContent;
    $("#FichaTecnica > a").attr("href", "/AdminFichaTecnica/Index/" + id)
}