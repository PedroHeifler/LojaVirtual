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

        public IList<Login> ListaPaginacao(int paginacao, int registros)
        {
            using (var contexto = new LojaVirtualContext())
            {
                var logins = contexto.Logins.Include("Usuario").ToList();
                var loginsPaginados = logins.OrderBy(p => p.IdLogin).Skip((paginacao - 1) * registros).Take(registros);
                return loginsPaginados.ToList();
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
                login.Usuario = contexto.Usuarios.Find(login.Usuario.IdUsuario);
                contexto.Update(login);
                contexto.SaveChanges();
            }
        }

        public Login Busca(string email, string senha)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Logins.Include("Usuario").FirstOrDefault(u => u.Email == email && u.Senha == senha);
            }
        }
    }
}