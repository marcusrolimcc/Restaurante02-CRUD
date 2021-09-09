using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_funcionario")]
        public int Id_funcionario { get; set; }

        [Column("id_cliente")]
        public int Id_cliente { get; set; }
    }
}
