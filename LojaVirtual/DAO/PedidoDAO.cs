using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DAO
{
    public class PedidoDAO
    {
        public void Atualiza(Pedido pedido)
        {
            using (var contexto = new LojaVirtualContext())
            {
                contexto.Update(pedido);
                contexto.SaveChanges();
            }
        }
    }
}