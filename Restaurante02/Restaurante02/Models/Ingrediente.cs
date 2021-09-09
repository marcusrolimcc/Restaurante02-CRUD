using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    [Table("Ingrediente")]
    public class Ingrediente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("validade")]
        public DateTime Validade { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }
    }
}
