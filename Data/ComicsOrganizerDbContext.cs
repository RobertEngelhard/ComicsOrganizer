using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data
{
    public class ComicsOrganizerDbContext : DbContext
    {
        public ComicsOrganizerDbContext(DbContextOptions<ComicsOrganizerDbContext> options) : base(options)
        {
        }

        public DbSet<ComicsSeries> ComicsSeries { get; set; }
        public DbSet<ComicsAlbums> ComicsAlbums { get; set; }

        protected virtual void ApplyConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ComicsSeriesConfiguration());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfigurations(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }




        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}