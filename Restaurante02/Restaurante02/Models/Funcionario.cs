using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("salario")]
        public decimal Salario { get; set; }

        [Column("id_restaurante")]
        public int Id_restaurante { get; set; }
    }
}
