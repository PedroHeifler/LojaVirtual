using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adiciona(Login login)
        {
            LoginDAO dao = new LoginDAO();
            dao.Adiciona(login);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Autentica(string email, string senha)
        {
            LoginDAO dao = new LoginDAO();
            Login login = dao.Busca(email, senha);
            if(login == null)
            {
                Session["usuarioLogado"] = login;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}