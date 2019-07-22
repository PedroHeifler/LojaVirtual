using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminProdutoController : Controller
    {
        // GET: AdminProduto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Produto produto)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.Adiciona(produto);
            return RedirectToAction("Index");
        }

        
        public ActionResult Excluir(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto produto = dao.BuscaPorId(id);
            dao.Excluir(produto);
            return Json(produto);
        }
    }
}