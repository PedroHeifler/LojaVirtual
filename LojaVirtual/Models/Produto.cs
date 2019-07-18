using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required]
        public int SKU { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}