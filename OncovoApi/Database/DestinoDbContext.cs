using Microsoft.EntityFrameworkCore;
using OncovoApi.Model;

namespace OncovoApi.Database
{
    public class DestinoDbContext : DbContext
    {
        public DestinoDbContext(DbContextOptions<DestinoDbContext>options) : base(options){

        }

        public DbSet<Destino> Destinos {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var destinos = modelBuilder.Entity<Destino>();
            destinos.ToTable("destinos");
            destinos.HasKey(x => x.Id);
            destinos.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            destinos.Property(x => x.CidadeNome).HasColumnName("cidade").IsRequired();
            destinos.Property(x => x.EstadoPaisNome).HasColumnName("estado_pais").IsRequired();

        }
    }
}