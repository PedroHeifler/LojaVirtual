using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.DAO
{
    public class FichaTecnicaDAO
    {
        public IList<FichaTecnica> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.FichaTecnicas.Include("Produtos").ToList();
            }
        } 

        public void Atualiza(FichaTecnica ficha)
        {
            using (var contexto = new LojaVirtualContext())
            {
                ficha.Produtos = contexto.Produtos.Find(ficha.Produtos.IdProduto);
                contexto.Update(ficha);
                contexto.SaveChanges();
            }
        }

        public void Excluir(FichaTecnica ficha)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Remove(ficha);
                contexto.SaveChanges();
            }
        }

        public FichaTecnica BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.FichaTecnicas.Find(id);
            }
        }
    }
}