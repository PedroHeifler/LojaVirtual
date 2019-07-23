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
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Endereco enderecos)
        {
            EnderecoDAO dao = new EnderecoDAO();
            dao.Adiciona(enderecos);
            return RedirectToAction("Index");
        }

    }
}