using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.ValueObject;
using EPVA.Domain.PlanoAula;
using Microsoft.EntityFrameworkCore;

namespace EPVA.Repository.Context
{
    public class EPVAContext : DbContext
    {

        public EPVAContext(DbContextOptions<EPVAContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EPVAContext).Assembly);
            modelBuilder.Entity<Aluno>().OwnsOne(x => x.Email)
                .Property(x => x.Valor)
                .HasColumnName("Email")
                .IsRequired(true);
            modelBuilder.Entity<Aluno>().OwnsOne(x => x.Password)
                .Property(x => x.Valor)
                .HasColumnName("Password")
                .IsRequired(true);
            modelBuilder.Entity<Professor>().OwnsOne(x => x.Email)
                .Property(x => x.Valor)
                .HasColumnName("Email")
                .IsRequired(true);
            modelBuilder.Entity<Professor>().OwnsOne(x => x.Password)
                .Property(x => x.Valor)
                .HasColumnName("Password")
                .IsRequired(true);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Material> Material { get; set; }
    }
}
