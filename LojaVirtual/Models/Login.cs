using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public String TpUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}