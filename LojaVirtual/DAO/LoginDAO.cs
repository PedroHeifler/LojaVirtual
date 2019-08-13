using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.DAO
{
    public class LoginDAO
    {
        public void Salva(Login login)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Logins.Add(login);
                contexto.SaveChanges();
            }
        }

        public IList<Login> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Logins.Include("Usuario").ToList();
            }
        }

        public Login BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Logins.Find(id);
            }
        }

        public void Atualiza(Login login)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(login);
                contexto.SaveChanges();
            }
        }

        public Login Busca(string email, string senha)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Logins.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            }
        }
    }
}