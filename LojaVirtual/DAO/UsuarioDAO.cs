using LojaVirtual.Models;
using System;
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

        public IList<Usuario> ListaPaginacao(int paginacao, int reginstros)
        {
            using (var contexto = new LojaVirtualContext())
            {
                var usuario = contexto.Usuarios.ToList();
                var usuarioPaginados = usuario.OrderBy(p => p.IdUsuario).Skip((paginacao - 1) * reginstros).Take(reginstros);
                return usuarioPaginados.ToList();
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