using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using WebApiDesafio.Repository.Models;

namespace WebApiDesafio.Repository
{
    public class CartaoContext : DbContext
    {
        public CartaoContext(DbContextOptions<CartaoContext> options) : base(options) { }
        public DbSet<tabContaCorrente> ContaCorrente { get; set; }
        public DbSet<tabSaldo> Saldo { get; set; }
        public DbSet<tabPessoa> Pessoa { get; set; }
        public DbSet<tabCartao> Cartao { get; set; }
        public DbSet<tabHis_Trans> His_Trans { get; set; }
        public DbSet<TabUsuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tabContaCorrente>().ToTable("tabContaCorrente");
            modelBuilder.Entity<tabSaldo>().ToTable("tabSaldo");
            modelBuilder.Entity<tabPessoa>().ToTable("tabPessoa");
            modelBuilder.Entity<tabCartao>().ToTable("tabCartao");
            modelBuilder.Entity<tabHis_Trans>().ToTable("tabHis_Trans");
            modelBuilder.Entity<TabUsuario>().ToTable("tabUsuario");
        }
    }
}
