using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;
            return View();
        }

        public ActionResult Adicionar(Endereco endereco, Login login, Usuario usuario)
        {
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            LoginDAO loginDAO = new LoginDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            enderecoDAO.Atualiza(endereco);
            loginDAO.Atualiza(login);
            usuarioDAO.Atualiza(usuario);
            return RedirectToAction("Index", "Home");
        }
    }
}