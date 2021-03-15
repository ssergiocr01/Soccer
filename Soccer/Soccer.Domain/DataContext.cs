using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Soccer.Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<League> Leagues { get; set; }

        public System.Data.Entity.DbSet<Soccer.Domain.Team> Teams { get; set; }
    }
}
