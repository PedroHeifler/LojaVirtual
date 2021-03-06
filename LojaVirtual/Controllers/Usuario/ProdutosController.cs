﻿using LojaVirtual.DAO;
using LojaVirtual.Models;
using System;
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

            ViewBag.SessionLogin = Session["usuarioLogado"];
            return View(produtos);

        }

        [HttpPost]
        public ActionResult BuscarProdutoPorIdCategoria(int id)
        {
            ProdutoDAO pdao = new ProdutoDAO();
            IList<Produto> produtos = pdao.BuscaProdutoPorDepartamento(id);

            IList<Produto> produtoslista = new List<Produto>();
            foreach (var prod in produtos)
            {
                produtoslista.Add(new Produto()
                {
                    IdProduto = prod.IdProduto
                });
            }

            return Json(produtoslista);
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

            ViewBag.SessionLogin = Session["usuarioLogado"];
            return View(produto);
        }

        public ActionResult Carrinho()
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;

            ViewBag.SessionLogin = Session["usuarioLogado"];

            if (ViewBag.SessionLogin != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Endereco()
        {
            /*---Departamento---*/
            DepartamentoDAO dao = new DepartamentoDAO();
            IList<Departamento> departamentos = dao.Lista();
            ViewBag.Departamentos = departamentos;

            LoginDAO ldao = new LoginDAO();
            IList<Login> logins = ldao.Lista();
            ViewBag.Logins = logins;

            EnderecoDAO edao = new EnderecoDAO();
            IList<Endereco> enderecos = edao.Lista();

            IList<Endereco> enderecosUsuarios = new List<Endereco>();

            ViewBag.SessionLogin = Session["usuarioLogado"];

            for (int i = 0; i < enderecos.Count; i++)
            {
                if (ViewBag.SessionLogin == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (enderecos[i].Usuario.IdUsuario == ViewBag.SessionLogin.Usuario.IdUsuario)
                {
                    enderecosUsuarios.Add(enderecos[i]);
                }

            }
            ViewBag.Enderecos = enderecosUsuarios;
            return View();
        }

        public ActionResult Pagamento()
        {
            ViewBag.SessionLogin = Session["usuarioLogado"];

            if (ViewBag.SessionLogin == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                /*---Departamento---*/
                DepartamentoDAO dao = new DepartamentoDAO();
                IList<Departamento> departamentos = dao.Lista();
                ViewBag.Departamentos = departamentos;

                ViewBag.SessionLogin = Session["usuarioLogado"];

                return View();
            }
        }
    }
}