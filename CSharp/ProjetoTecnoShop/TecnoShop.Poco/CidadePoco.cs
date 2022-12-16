using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class CidadePoco
    {
        public int CodigoCidade { get; set; }
        public string Nome { get; set; } = null!;
        public int CodigoIBGE7 { get; set; }
        public int CodigoEstado { get; set; }

        public CidadePoco()
        { }
    }
}
