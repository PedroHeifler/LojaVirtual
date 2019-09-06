function MandarParaProdutos(e) {
    if (e.keyCode == 13) {
        window.location.href = "http://localhost:61651/Produtos";
        return false;
    }
    else {
        return true;
    }
}