using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    [Table("Item_Venda")]
    public class Item_Venda
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_venda")]
        public int Id_venda { get; set; }

        [Column("id_prato")]
        public int Id_prato { get; set; }
    }
}
