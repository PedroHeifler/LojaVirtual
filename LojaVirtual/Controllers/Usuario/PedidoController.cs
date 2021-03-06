﻿using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.cUsuario
{
    public class PedidoController : Controller
    {
        public object PedidoDAO { get; private set; }

        // GET: Pedido
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Grava(int id)
        {
            
            ProdutoDAO pdao = new ProdutoDAO();
            Pedido pedido = new Pedido();
            PedidoDAO pedao = new PedidoDAO();
            LoginDAO ldao = new LoginDAO();

            DateTime data = DateTime.Today;

            
            pedido.dataDaCampra = data;
            var login = (Login)Session["usuarioLogado"];
            pedido.Usuario = ldao.Busca(login);

            var produtoNovo = pdao.BuscaPorId(id);
            pedido.Produtos.Add(produtoNovo);
            pedido.valor = produtoNovo.Valor;

            pedao.Atualiza(pedido);

            return RedirectToAction("Index", "Home");

        }
    }
}