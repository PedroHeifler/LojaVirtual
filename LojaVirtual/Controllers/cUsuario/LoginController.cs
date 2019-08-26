using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.cUsuario
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String email, String senha)
        {
            LoginDAO dao = new LoginDAO();
            Login login = dao.Busca(email, senha);
            
            if (login != null)
            {
                Session["usuarioLogado"] = login;
                return RedirectToAction("Index", "Home");
            }
            else
            { 
                return RedirectToAction("Index");
            }
        }

        public ActionResult Sair()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}