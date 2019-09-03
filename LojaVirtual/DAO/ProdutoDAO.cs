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
                return contexto.Produtos.Include("Departamento").Include("Pedido").ToList();
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
                Departamento departamento = new Departamento();
                departamento.Produtos.Add(produto);
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

        public IList<Produto> BuscaProdutoPorDepartamento(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Departamentos.Include("Produtos").ToList();
                return contexto.Departamentos.Find(id).Produtos.ToList();
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

        /*public object BuscarValorPorMesAno()
        {
            using(var contexto = new LojaVirtualContext())
            {
                return contexto.Pedidos.Include("Produtos").FromSql("SELECT SUM(PED.idPedido) as idPedido, SUM(PED.UsuarioIdUsuario) as UsuarioIdUsuario, SUM(PED.valor) as valor, MONTH(PED.dataDaCampra) AS dataDaCampra, COALESCE( ( SELECT SUM(PED2.VALOR) FROM PEDIDOS PED2 INNER JOIN Produtos PROD ON (PROD.PedidoidPedido = PED2.idPedido) INNER JOIN Departamentos DEPTO ON (DEPTO.IdDepartamento = PROD.DepartamentoIdDepartamento) WHERE YEAR(PED2.dataDaCampra) = YEAR(PED.dataDaCampra) AND MONTH(PED2.dataDaCampra) = MONTH(PED.dataDaCampra) AND DEPTO.Genero = 'Masculino'), 0) as Masculino, COALESCE(( SELECT SUM(PED2.VALOR) FROM PEDIDOS PED2 INNER JOIN Produtos PROD ON (PROD.PedidoidPedido = PED2.idPedido) INNER JOIN Departamentos DEPTO ON (DEPTO.IdDepartamento = PROD.DepartamentoIdDepartamento) WHERE YEAR(PED2.dataDaCampra) = YEAR(PED.dataDaCampra) AND MONTH(PED2.dataDaCampra) = MONTH(PED.dataDaCampra) AND DEPTO.Genero = 'Feminino'), 0) as Feminino, COALESCE(( SELECT SUM(PED2.VALOR) FROM PEDIDOS PED2 INNER JOIN Produtos PROD ON (PROD.PedidoidPedido = PED2.idPedido) INNER JOIN Departamentos DEPTO ON (DEPTO.IdDepartamento = PROD.DepartamentoIdDepartamento) WHERE YEAR(PED2.dataDaCampra) = YEAR(PED.dataDaCampra) AND MONTH(PED2.dataDaCampra) = MONTH(PED.dataDaCampra) AND DEPTO.Genero = 'Infantil'), 0) as Infantil FROM PEDIDOS PED GROUP BY MONTH(PED.dataDaCampra)").ToArray();

            }
        }*/
    }
}