using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DAO
{
    public class EnderecoDAO
    {
        public IList<Endereco> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Enderecos.ToList();
            }
        }

        public Endereco BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Enderecos.Find(id);
            }
        }

        public void Atualiza(Endereco endereco)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(endereco);
                contexto.SaveChanges();
            }
        }

        public Endereco Busca(int idEndereco)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Enderecos.FirstOrDefault(u => u.IdEndereco == idEndereco);
            }
        }
    }
}