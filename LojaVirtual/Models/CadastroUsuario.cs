using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Models
{
    public class CadastroUsuario
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public String NomeCompleto { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
    }
}