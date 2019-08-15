using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Login = new List<Login>();
            Endereco = new List<Endereco>();
        }
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Telefone { get; set; }

        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}