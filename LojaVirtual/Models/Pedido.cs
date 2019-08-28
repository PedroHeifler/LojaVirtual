using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Produtos = new List<Produto>(); 
        }

        [Key]
        public int idPedido { get; set; }
        [Required]
        public DateTime dataDaCampra { get; set; }
        [Required]
        public double valor { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}