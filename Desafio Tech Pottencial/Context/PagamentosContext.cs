using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Tech_Pottencial.Models;
using Microsoft.EntityFrameworkCore;


namespace Desafio_Tech_Pottencial.Context
{
    public class PagamentosContext : DbContext
    {
        public PagamentosContext(DbContextOptions<PagamentosContext> options) : base(options)
        {

        }
        public DbSet<Venda> Vendas {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}
        public DbSet<Item> Itens {get; set;}
    }
}