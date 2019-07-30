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
        public string Imagem { get; set; }
        
        public virtual Departamento Departamento { get; set; }

    }
}