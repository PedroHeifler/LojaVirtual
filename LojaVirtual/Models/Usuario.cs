using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class Usuario
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

        public virtual Login Login { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}