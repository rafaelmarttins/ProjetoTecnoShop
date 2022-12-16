using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnoShop.Domain.EF;

namespace TecnoShop.Domain.EF
{
    public partial class TecnoShopContext : DbContext
    {
        public DbSet<Estado> Estados { get; set; } = null!;
        public DbSet<Cidade> Cidades { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Marca> Marcas { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Loja> Lojas { get; set; } = null!;
        public DbSet<Gerente> Gerentes { get; set; } = null!;
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Venda> Vendas { get; set; } = null!;
        public DbSet<VendaItem> VendaItems { get; set; } = null!;
        public DbSet<Estoque> Estoques { get; set; } = null!;

        public TecnoShopContext() : base()
        { }

        public TecnoShopContext(DbContextOptions<TecnoShopContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Aqui ficava a Connection StrinSg.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Loja>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Gerente>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<VendaItem>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

