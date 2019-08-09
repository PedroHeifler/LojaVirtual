using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class FichaTecnica
    {
        [Key]
        public int IdFichaTecnica { get; set; }
        public string Ficha { get; set; }
        public string Conteudo { get; set; }
        public int Ordem { get; set; }  

        public virtual Produto Produtos { get; set; }
    }
}