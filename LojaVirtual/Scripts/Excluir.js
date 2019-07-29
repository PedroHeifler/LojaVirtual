function Excluir(id, url) {

    $.post(url, { id: id }, atualiza(id))
        .fail(function () {
            $(".msg-erro").toggle();
            setTimeout(function () {
                $(".msg-erro").toggle();
            }, 2000);
        })

function atualiza(id) {
    var tr = $('#adminTr' +  id)
    tr.fadeOut(400, function () { tr.remove(); });
}
}
