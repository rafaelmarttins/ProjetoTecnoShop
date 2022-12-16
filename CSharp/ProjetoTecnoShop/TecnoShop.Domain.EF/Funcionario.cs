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
    [Table("funcionario", Schema = "dbo")]
    public partial class Funcionario
    {
        [Key]
        [Column(name: "funcionario_id")]
        public int CodigoFuncionario { get; set; }

        [Column(name: "primeiro_nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Nome { get; set; } = null!;

        [Column(name: "sobrenome_nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Sobrenome { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(25)]
        public string Telefone { get; set; } = null!;

        [Column(name: "ativo")]
        public bool? Ativo { get; set; }

        [Column(name: "loja_id")]
        public int CodigoLoja { get; set; }

        [Column(name: "gerente_id")]
        public int CodigoGerente { get; set; }
    }
}