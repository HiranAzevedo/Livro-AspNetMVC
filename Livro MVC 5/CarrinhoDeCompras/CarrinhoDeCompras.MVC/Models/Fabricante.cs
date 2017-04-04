using System.Collections.Generic;

namespace CarrinhoDeCompras.MVC.Models
{
    public class Fabricante
    {
        public long FabricanteId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}