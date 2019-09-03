using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.Admin
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listarDepartamento()
        {
            DepartamentoDAO ddao = new DepartamentoDAO();
            IList<Departamento> departamento = ddao.Lista();

            return Json(departamento);
        }

        public ActionResult listarProdutosPorCategoria()
        {
            ProdutoDAO pdao = new ProdutoDAO();
            var produtos = pdao.BuscaProdutoPorCategoria();
            return Json(produtos);
        }

        public ActionResult listarValorMesAno()
        {
            ProdutoDAO pdao = new ProdutoDAO();
            var valores = pdao.BuscarValorPorMesAno();
            return Json(valores);
        }
    }
}