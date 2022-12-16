using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class EnderecoPoco
    {
        public int CodigoEndereco { get; set; }
        public string Rua { get; set; } = null!;
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public int CodigoCidade { get; set; }

        public EnderecoPoco()
        { }
    }
}
