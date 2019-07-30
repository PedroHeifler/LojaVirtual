using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminUsuarioController : Controller
    {
        // GET: AdminUsuario
        public ActionResult Index()
        {
            UsuarioDAO dao = new UsuarioDAO();
            IList<Usuario> usuarios = dao.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }

        [HttpPost]
        public ActionResult Salva(Usuario usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();

            dao.Atualiza(usuario);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.BuscaPorId(id);
            dao.Excluir(usuario);
            return Json(usuario);
        }
    }
}