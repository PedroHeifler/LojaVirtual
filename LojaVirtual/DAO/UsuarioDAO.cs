using LojaVirtual.Models;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.DAO
{
    public class UsuarioDAO
    {

        public IList<Usuario> Lista()
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }

        public void Atualiza(Usuario usuario)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(usuario);
                contexto.SaveChanges();
            }
        }

        public Usuario Busca(int idUsuario)
        {
            using (var contexto = new LojaVirtualContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            }
        }

        public void Excluir(Usuario usuario)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Remove(usuario);
                contexto.SaveChanges();
            }
        }
    }
}