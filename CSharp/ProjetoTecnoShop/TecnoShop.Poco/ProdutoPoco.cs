using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class ProdutoPoco
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; } = null!;
        public int CodigoMarca { get; set; }
        public int CodigoCategoria { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public bool? Ativo { get; set; }

        public ProdutoPoco()
        { }
    }
}
