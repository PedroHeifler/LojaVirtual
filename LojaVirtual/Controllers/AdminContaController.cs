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
            LoginDAO dao = new LoginDAO();
            IList<Login> logins = dao.Lista();
            ViewBag.Login = logins;
            return View();
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