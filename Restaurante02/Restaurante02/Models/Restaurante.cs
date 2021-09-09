using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
       [Key]
       [Column("id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }
    }
}
