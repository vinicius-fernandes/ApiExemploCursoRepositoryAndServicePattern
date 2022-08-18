using ApiExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExemplo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                        .HasMany(empresa => empresa.Transacoes)
                        .WithOne(transacao => transacao.Empresa);
          
        }
    }
}
