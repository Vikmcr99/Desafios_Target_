using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target_4
{
    public class _Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoTelefone> TiposTelefones { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("fakeConnectionString");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Estado)
                .WithMany(e => e.Clientes)
                .HasForeignKey(c => c.EstadoID);

            modelBuilder.Entity<Telefone>()
                .HasOne(t => t.Cliente)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.ClienteID);

            modelBuilder.Entity<Telefone>()
                .HasOne(t => t.TipoTelefone)
                .WithMany(tt => tt.Telefones)
                .HasForeignKey(t => t.TipoTelefoneID);
        }
    }
}
