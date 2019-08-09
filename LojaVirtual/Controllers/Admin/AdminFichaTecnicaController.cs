using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.Admin
{
    public class AdminFichaTecnicaController : Controller
    {
        // GET: AdminFichaTecnica
        public ActionResult Index(int id)
        {
            FichaTecnicaDAO dao = new FichaTecnicaDAO();
            ProdutoDAO pdao = new ProdutoDAO();
            Produto produto = pdao.BuscaPorId(id);
            IList<Produto> produtos = pdao.Lista();
            IList<FichaTecnica> fichas = dao.Lista();
            ViewBag.Produto = produtos;
            ViewBag.Ficha = fichas;
            return View(produto);

        }

        [HttpPost]
        public ActionResult Salva(FichaTecnica ficha)
        {
            FichaTecnicaDAO dao = new FichaTecnicaDAO();
            dao.Atualiza(ficha);
            return RedirectToAction("Index/" + ficha.Produtos.IdProduto);

        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            FichaTecnicaDAO dao = new FichaTecnicaDAO();
            FichaTecnica ficha = dao.BuscaPorId(id);
            dao.Excluir(ficha);
            return Json(ficha);
        }
    }
}