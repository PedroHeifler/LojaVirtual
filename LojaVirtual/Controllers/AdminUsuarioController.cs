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
        public ActionResult Adicionar(Usuario usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();
            dao.Adiciona(usuario);
            dao.Atualiza(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int id)
        {
            UsuarioDAO dao = new UsuarioDAO();
            
            return RedirectToAction("Index");
        }
    }
}