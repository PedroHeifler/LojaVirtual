using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Models
{
    public class CadastroUsuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public String NomeCompleto { get; set; }
        [Required]
        public String CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public String Telefone { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public int LoginId { get; set; }
        public Login Login { get; set; }
    }
}