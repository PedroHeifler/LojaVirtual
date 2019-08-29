using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.cUsuario
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

            login.TpUsuario = "Usuario";

            usuario.Login.Add(login);
            usuario.Endereco.Add(endereco);

            usuarioDAO.Atualiza(usuario);
            enderecoDAO.Atualiza(endereco);
            loginDAO.Atualiza(login);
            return RedirectToAction("Index", "Home");
        }
    }
}