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
        public void Adiciona(Produto produto)
        {
            using (var context = new LojaVirtualContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public IList<Produto> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Produtos.ToList();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Produtos.Find(id);
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(produto);
                contexto.SaveChanges();
            }
        }

        public Produto Busca(int idProduto)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Produtos.FirstOrDefault(u => u.IdProduto == idProduto);
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