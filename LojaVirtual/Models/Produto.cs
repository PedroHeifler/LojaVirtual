using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Imagem { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string TpProduto { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<FichaTecnica> FichaTecnicas { get; set; }

    }
}