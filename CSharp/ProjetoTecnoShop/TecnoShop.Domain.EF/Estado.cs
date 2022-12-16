using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace TecnoShop.Domain.EF
{
    [Table("estado", Schema = "dbo")]
    public partial class Estado
    {
        [Key]
        [Column(name: "estado_id")]
        public int CodigoEstado { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUF { get; set; } = null!;
    }
}