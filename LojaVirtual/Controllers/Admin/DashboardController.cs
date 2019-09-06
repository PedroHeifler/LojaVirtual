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
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if(ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                return View();
            }else
            {
                return RedirectToAction("Index", "Home");
            }
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