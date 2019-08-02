using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.cUsuario
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;

            /*---Produto---*/
            ProdutoDAO pdao = new ProdutoDAO();
            IList<Produto> produtos = pdao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}