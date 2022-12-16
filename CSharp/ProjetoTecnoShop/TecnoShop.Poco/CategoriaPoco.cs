using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class CategoriaPoco
    {
        public int CodigoCategoria { get; set; }
        public string NomeCategoria { get; set; } = null!;
        public bool? Ativo { get; set; }

        public CategoriaPoco()
        { }
    }
}
