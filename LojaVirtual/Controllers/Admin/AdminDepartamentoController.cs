using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.Admin
{
    public class AdminDepartamentoController : Controller
    {
        // GET: AdminDepartamento
        public ActionResult Index()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                DepartamentoDAO dao = new DepartamentoDAO();
                IList<Departamento> departamentos = dao.Lista();
                ViewBag.Departamento = departamentos;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult Salva(Departamento departamento)
        {
            DepartamentoDAO dao = new DepartamentoDAO();

            dao.Atualiza(departamento);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            DepartamentoDAO dao = new DepartamentoDAO();
            Departamento departamento = dao.BuscaPorId(id);
            dao.Excluir(departamento);
            return Json(departamento);
        }
    }
}