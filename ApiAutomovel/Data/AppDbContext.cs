using ApiAutomovel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAutomovel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Automovel> Automeveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AutomoveisCreation(modelBuilder);
        }

        private void AutomoveisCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Modelo)
                        .HasMaxLength(150);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Placa)
                        .HasMaxLength(8);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Descricao)
                        .HasMaxLength(600);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Modelo)
                        .HasPrecision(12, 2);

            modelBuilder.Entity<Automovel>()
                        .HasData(
                                new Automovel { Id = 1, Descricao = "é um carro quadrado com 3 rodas", Modelo = "Ford triciclo", Placa = "asn 1111", Preco = 500.00M }
                        );
        }
    }
}
