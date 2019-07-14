using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Models
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Senha { get; set; }
        public String TpUsuario { get; set; }

    }
}