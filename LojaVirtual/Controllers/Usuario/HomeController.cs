using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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