using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Poco
{
    public class VendaPoco
    {
        public int CodigoVenda { get; set; }
        public int CodigoCliente { get; set; }
        public int VendaStatus { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataPreparo { get; set; }
        public DateTime DataEnvio { get; set; }
        public int CodigoLoja { get; set; }
        public int CodigoFuncionario { get; set; }
        public bool? Ativo { get; set; }

        public VendaPoco()
        { }
    }
}
