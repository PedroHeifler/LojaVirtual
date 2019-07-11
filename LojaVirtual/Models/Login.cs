using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Models
{
    public class Login
    {
        [Key, Column(Order = 1)]
        public int IdLogin { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String TpUsuario { get; set; }
    }
}