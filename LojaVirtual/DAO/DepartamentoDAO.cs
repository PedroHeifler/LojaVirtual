using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.DAO
{
    public class DepartamentoDAO
    {
        public IList<Departamento> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Departamentos.ToList();
            }
        }

        public void Atualiza(Departamento departamento)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(departamento);
                contexto.SaveChanges();
            }
        }

        public Departamento BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Departamentos.Find(id);
            }
        }

        public Departamento Busca(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Departamentos.FirstOrDefault(u => u.IdDepartamento == id);
            }
        }

        public void Excluir(Departamento departamento)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Remove(departamento);
                contexto.SaveChanges();
            }
        }
    }
}