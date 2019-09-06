using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminEnderecoController : Controller
    {
        // GET: AdminEndereco
        public ActionResult Index()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                EnderecoDAO dao = new EnderecoDAO();
                IList<Endereco> enderecos = dao.Lista();
                ViewBag.Enderecos = enderecos;

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
            EnderecoDAO dao = new EnderecoDAO();
            IList<Endereco> enderecos = dao.ListaPaginacao(paginacao, registros);
            ViewBag.Enderecos = enderecos;

            UsuarioDAO udao = new UsuarioDAO();
            IList<Usuario> usuarios = udao.Lista();
            ViewBag.Usuarios = usuarios;
            return PartialView("_Listar");
        }

        [HttpPost]
        public ActionResult Salva(Endereco endereco)
        {
            EnderecoDAO dao = new EnderecoDAO();

            dao.Atualiza(endereco);
            return RedirectToAction("Index");

        }
    }
}