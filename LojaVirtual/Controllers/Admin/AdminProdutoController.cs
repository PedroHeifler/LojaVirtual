using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdminProdutoController : Controller
    {
        // GET: AdminProduto
        public ActionResult Index()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];
            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ViewBag.SessionLogin.TpUsuario == "Admin")
            {
                ProdutoDAO dao = new ProdutoDAO();
                DepartamentoDAO DepDAO = new DepartamentoDAO();
                FichaTecnicaDAO ficDAO = new FichaTecnicaDAO();
                IList<FichaTecnica> ficha = ficDAO.Lista();
                IList<Produto> produtos = dao.Lista();
                IList<Departamento> departamentos = DepDAO.Lista();
                ViewBag.Ficha = ficha;
                ViewBag.Departamento = departamentos;
                ViewBag.Produtos = produtos;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public PartialViewResult Listar(int paginacao = 1, int registros = 5)
        {
            ProdutoDAO dao = new ProdutoDAO();
            DepartamentoDAO DepDAO = new DepartamentoDAO();
            FichaTecnicaDAO ficDAO = new FichaTecnicaDAO();
            IList<FichaTecnica> ficha = ficDAO.Lista();
            IList<Produto> produtos = dao.ListaPaginacao(paginacao, registros);
            IList<Departamento> departamentos = DepDAO.Lista();
            ViewBag.Ficha = ficha;
            ViewBag.Departamento = departamentos;
            ViewBag.Produtos = produtos;
            return PartialView("_Listar");
        }

        [HttpPost]
        public ActionResult Salva(Produto produto)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.Atualiza(produto);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto produto = dao.BuscaPorId(id);
            dao.Excluir(produto);
            return Json(produto);
        }
    }
}