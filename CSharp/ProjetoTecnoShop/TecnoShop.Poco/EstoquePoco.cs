using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class EstoquePoco
    {
        public int CodigoEstoque { get; set; }
        public int CodigoLoja { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public bool? Ativo { get; set; }

        public EstoquePoco()
        { }
    }
}
