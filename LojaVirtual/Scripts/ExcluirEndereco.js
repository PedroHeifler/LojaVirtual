function ExcluirE(id) {

    var url = "http://localhost:61651/AdminEndereco/Excluir";
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
    var tr = $("#endereco" + resposta.IdEndereco)
    tr.fadeOut(400, function () { tr.remove(); });
}