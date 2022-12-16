using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TecnoShop.Domain.EF
{
    [Table("venda", Schema = "dbo")]
    public partial class Venda
    {
        [Key]
        [Column(name: "venda_id")]
        public int CodigoVenda { get; set; }

        [Column(name: "cliente_id")]
        public int CodigoCliente { get; set; }

        [Column(name: "venda_status")]
        public int VendaStatus { get; set; }

        [Column(name: "data_venda", TypeName = "date")]
        public DateTime DataVenda { get; set; }

        [Column(name: "data_preparo", TypeName = "date")]
        public DateTime DataPreparo { get; set; }

        [Column(name: "data_envio", TypeName = "date")]
        public DateTime DataEnvio { get; set; }

        [Column(name: "loja_id")]
        public int CodigoLoja { get; set; }

        [Column(name: "funcionario_id")]
        public int CodigoFuncionario { get; set; }

        [Column(name: "ativo")]
        public bool? Ativo { get; set; }
    }
}
