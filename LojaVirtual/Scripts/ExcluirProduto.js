function ExcluirP(id) {

    var url = "http://localhost:61651/AdminProduto/Excluir";
    $.post(url, { id: id }, atualiza)
        .fail(function () {
            $(".msg-erro").toggle();
            setTimeout(function () {
                $(".msg-erro").toggle();
            }, 2000);
        })

}

function atualiza(resposta) {
    console.log(resposta)
    var tr = $("#produto" + resposta.IdProduto)
    tr.fadeOut(400, function () { tr.remove(); });
}