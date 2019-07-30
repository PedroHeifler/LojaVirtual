﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    public class Departamento
    {
        public Departamento()
        {
            Produtos = new HashSet<Produto>();
        }

        [Key]
        public int IdDepartamento { get; set; }
        [Required]
        public string Genero { get; set; }
        
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}