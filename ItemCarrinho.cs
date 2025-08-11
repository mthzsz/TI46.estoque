using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46.estoque._0._1
{
    internal class ItemCarrinho
    {
        public string CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal => Quantidade * ValorUnitario; // Calcula automaticamente o subtotal
    }
}
