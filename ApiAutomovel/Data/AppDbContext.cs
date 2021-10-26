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
            TipoCarroCreation(modelBuilder);
            AutomoveisCreation(modelBuilder);
        }
        
        private void AutomoveisCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Modelo)
                        .HasMaxLength(150);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Placa)
                        .HasMaxLength(30);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Placa)
                        .HasMaxLength(8);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Descricao)
                        .HasMaxLength(600);

            modelBuilder.Entity<Automovel>()
                        .Property(p => p.Preco)
                        .HasPrecision(12, 2);

            modelBuilder.Entity<Automovel>()
                        .HasData(
                                    new Automovel
                                    {   
                                        Id = 1,
                                        Modelo = "Ford Focus",
                                        NumRodas = 4,
                                        Cor = "Branco",
                                        Placa = "asp-9823",
                                        NumPortas = 4,
                                        Descricao = "Carro semi novo",
                                        Preco = 30000,
                                        tipoCarro = 1
                                    }
                       );
        }

        private void TipoCarroCreation (ModelBuilder model)
        {
            model.Entity<TipoCarro>()
                .Property(p => p.TipoVeiculo)
                .HasMaxLength(150);

            model.Entity<TipoCarro>()
                .HasData(
                            new TipoCarro { Id = 1, TipoVeiculo = "Sedan" },
                            new TipoCarro { Id = 2, TipoVeiculo = "Picape"},
                            new TipoCarro { Id = 3, TipoVeiculo = "SUV"},
                            new TipoCarro { Id = 4, TipoVeiculo = "Esportivo"}
                );
        }
    }
}
