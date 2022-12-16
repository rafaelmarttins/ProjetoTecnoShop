using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class EstadoPoco
    {
        public int CodigoEstado { get; set; }
        public string Nome { get; set; } = null!;
        public string SiglaUF { get; set; } = null!;
        public EstadoPoco()
        { }
    }
}
