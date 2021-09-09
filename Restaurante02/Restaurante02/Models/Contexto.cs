using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante02.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Item_Prato> Item_Pratos { get; set; }
        public DbSet<Item_Venda> Item_Vendas { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}


