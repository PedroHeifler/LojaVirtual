﻿using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminProdutoController : Controller
    {
        // GET: AdminProduto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            DepartamentoDAO DepDAO = new DepartamentoDAO();
            FichaTecnicaDAO ficDAO = new FichaTecnicaDAO();
            IList<FichaTecnica> ficha = ficDAO.Lista();
            IList<Produto> produtos = dao.Lista();
            IList<Departamento> departamentos = DepDAO.Lista();
            ViewBag.Ficha = ficha;
            ViewBag.Departamento = departamentos;
            ViewBag.Produtos = produtos;
            return View();
        }

        [HttpPost]
        public ActionResult Salva(Produto produto)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.Atualiza(produto);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto produto = dao.BuscaPorId(id);
            dao.Excluir(produto);
            return Json(produto);
        }
    }
}