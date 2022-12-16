using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace TecnoShop.Domain.EF
{
    [Table("loja", Schema = "dbo")]
    public partial class Loja
    {
        [Key]
        [Column(name: "loja_id")]
        public int CodigoLoja { get; set; }

        [Column(name: "loja_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string Nome { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(25)]
        public string Telefone { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Column(name: "endereco_id")]
        public int CodigoEndereco { get; set; }

        [Column(name: "ativo")]
        public bool? Ativo { get; set; }
    }
}
