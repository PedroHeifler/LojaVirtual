using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminContaController : Controller
    {
        // GET: AdminConta
        public ActionResult Index()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                LoginDAO dao = new LoginDAO();
                IList<Login> logins = dao.Lista();
                ViewBag.Login = logins;

                UsuarioDAO udao = new UsuarioDAO();
                IList<Usuario> usuarios = udao.Lista();
                ViewBag.Usuarios = usuarios;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public PartialViewResult Listar(int paginacao = 1, int registros = 5)
        {
            LoginDAO dao = new LoginDAO();
            IList<Login> logins = dao.ListaPaginacao(paginacao, registros);
            ViewBag.Login = logins;

            UsuarioDAO udao = new UsuarioDAO();
            IList<Usuario> usuarios = udao.Lista();
            ViewBag.Usuarios = usuarios;
            return PartialView("_Listar");
        }

        [HttpPost]
        public ActionResult Salva(Login login)
        {
            LoginDAO dao = new LoginDAO();

            dao.Atualiza(login);
            return RedirectToAction("Index");

        }
    }
}