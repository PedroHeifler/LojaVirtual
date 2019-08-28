using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DAO
{
    public class ProdutoDAO
    {
        public IList<Produto> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Produtos.Include("Departamento").ToList();
            }
        }

        public IList<Produto> ListaPaginacao(int paginacao, int reginstros)
        {
            using (var contexto = new LojaVirtualContext())
            {
                var produtos = contexto.Produtos.Include("Departamento").ToList();
                var produtosPaginados = produtos.OrderBy(p => p.SKU).Skip((paginacao - 1) * reginstros).Take(reginstros);
                return produtosPaginados.ToList();
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new LojaVirtualContext())
            {
                produto.Departamento = contexto.Departamentos.Find(produto.Departamento.IdDepartamento);
                contexto.Update(produto);
                contexto.SaveChanges();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext()) 
            {
                return contexto.Produtos.FirstOrDefault(u => u.IdProduto == id);
            }
        }

        public Produto BuscaDepartamento(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Produtos.FirstOrDefault(u => u.Departamento.IdDepartamento == id);
            }
        }

        public void Excluir(Produto produto)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Remove(produto);
                contexto.SaveChanges();
            }
        }
    }
}