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
            EnderecoDAO dao = new EnderecoDAO();
            IList<Endereco> enderecos = dao.Lista();
            ViewBag.Enderecos = enderecos;

            UsuarioDAO udao = new UsuarioDAO();
            IList<Usuario> usuarios = udao.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
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