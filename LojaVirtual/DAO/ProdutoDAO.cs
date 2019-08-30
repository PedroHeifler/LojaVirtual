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
                return contexto.Produtos.Find(id);
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

        public object BuscaProdutoPorCategoria()
        {
            using (var contexto = new LojaVirtualContext())
            {
                var grouped = from b in contexto.Produtos
                              group b.Departamento by b.Departamento into g
                              select new
                              {
                                  Genero = g.Key.Genero,
                                  qtd = g.Count(),
                                  produto = g.Key.Produtos
                              };
                return grouped.ToList();
            }
        }

        public object BuscaPrecoPorCategoria()
        {
            using (var contexto = new LojaVirtualContext())
            {
                var grouped = from b in contexto.Pedidos
                              group b by b.dataDaCampra into g
                              select new
                              {
                                  Data = g.Key,
                                  Valor = g.Key

                              };
                return grouped.ToList();
            }
        }
    }
}