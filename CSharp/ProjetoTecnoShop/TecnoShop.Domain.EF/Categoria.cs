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
    [Table("Categoria", Schema = "dbo")]
    public partial class Categoria
    {
        [Key]
        [Column(name: "categoria_id")]
        public int CodigoCategoria { get; set; }

        [Column(name: "categoria_nome")]
        [Unicode(false)]
        [StringLength(255)] 
        public string NomeCategoria { get; set; } = null!;

        [Column(name: "ativo")]
        public bool? Ativo { get; set; }
    }
}
