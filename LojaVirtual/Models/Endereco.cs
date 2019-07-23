using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        [Required]
        public string CEP { get; set; } 
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Complemento { get; set; }

    }
}