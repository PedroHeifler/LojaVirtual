function Filtrar(seletor) {

    var usuarios = $(seletor);
    var campo = $("#filtro-tabela").on("input")
    if (usuarios.length > 0) {
        for (var i = 0; i < usuarios.length; i++) {
            var usuario = usuarios[i];
            var tdNome = usuario.querySelector(".info-nome");
            var nome = tdNome.textContent;
            var expressao = new RegExp(campo.val(), "i");
            
            if (!expressao.test(nome)) {
                usuario.classList.add("invisivel");
            } else {
                usuario.classList.remove("invisivel");
            }
        }
    } else {
        for (var i = 0; i < usuarios.length; i++) {
            var usuario = usuarios[i];
            usuario.classList.remove("invisivel");
        }
    }

    function FitrarProdutos(idDepartamento) {
        var produto = $(".filtro-produtos");

        if (produto.length > 0) {

        }

    }

}