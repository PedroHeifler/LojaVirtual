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
            DepartamentoDAO DepDAO = new DepartamentoDAO();
            IList<Departamento> departamentos = DepDAO.Lista();
            ViewBag.Departamento = departamentos;
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