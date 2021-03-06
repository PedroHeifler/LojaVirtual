﻿using LojaVirtual.DAO;
using System.Collections.Generic;
using System.Web.Mvc;
using LojaVirtual.Models;


namespace LojaVirtual.Controllers
{
    public class AdminUsuarioController : Controller
    {
        // GET: AdminUsuario
        public ActionResult Index()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                UsuarioDAO dao = new UsuarioDAO();
                IList<Usuario> usuarios = dao.Lista();
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
            UsuarioDAO dao = new UsuarioDAO();
            IList<Usuario> usuarios = dao.ListaPaginacao(paginacao, registros);
            ViewBag.Usuarios = usuarios;

            return PartialView("_Listar");
        }

        [HttpPost]
        public ActionResult Salva(Usuario usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();

            dao.Atualiza(usuario);
            return RedirectToAction("Index");

        }

    }
}