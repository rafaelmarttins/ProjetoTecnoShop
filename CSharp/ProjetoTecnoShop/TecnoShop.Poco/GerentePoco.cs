using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class GerentePoco
    {
        public int CodigoGerente { get; set; }
        public string Nome { get; set; } = null!;
        public string SobreNome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public bool? Ativo { get; set; }
        public int CodigoLoja { get; set; }

        public GerentePoco()
        { }
    }
}
