using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class VendaItemPoco
    {
        public int CodigoVendaItem { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoItem { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
        public bool? Ativo { get; set; }

        public VendaItemPoco()
        { }
    }
}
