
    function ExcluirU(id) {

        var url = "http://localhost:61651/AdminUsuario/Excluir"
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
        var tr = $("#usuario" + resposta.IdUsuario)
        tr.fadeOut(400, function () { tr.remove(); });
    }
