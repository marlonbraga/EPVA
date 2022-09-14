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
            base.OnModelCreating(modelBuilder);
        }
    }
}
