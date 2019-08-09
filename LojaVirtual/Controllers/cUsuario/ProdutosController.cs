using LojaVirtual.DAO;
using LojaVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers.cUsuario
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;

            /*---Produto---*/
            ProdutoDAO pdao = new ProdutoDAO();
            IList<Produto> produtos = pdao.Lista();
            ViewBag.Produtos = produtos;
            return View(produtos);
        }

        public ActionResult Filtrar(int idDepartemento)
        {
            DepartamentoDAO dDAO = new DepartamentoDAO();
            Departamento departamento = dDAO.BuscaPorId(idDepartemento);
            return Json(departamento);
        }

        public ActionResult Detalhes(int id)
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;

            /*---Ficha Tecnica---*/
            FichaTecnicaDAO fdao = new FichaTecnicaDAO();
            IList<FichaTecnica> fichaTecnicas = fdao.Lista();
            ViewBag.Ficha = fichaTecnicas;

            ProdutoDAO pdao = new ProdutoDAO();
            Produto produto = pdao.BuscaPorId(id);
            return View(produto);
        }

        public ActionResult Carrinho()
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;
            return View();
        }


    }
}