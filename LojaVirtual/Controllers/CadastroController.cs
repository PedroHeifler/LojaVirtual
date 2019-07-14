using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar(Endereco endereco, Login login, Usuario usuario)
        {
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            LoginDAO loginDAO = new LoginDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            enderecoDAO.Adiciona(endereco);
            loginDAO.Adiciona(login);
            usuarioDAO.Adiciona(usuario);
            return RedirectToAction("Index", "Home");
        }
    }
}