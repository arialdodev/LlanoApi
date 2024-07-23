using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Persistence
{
    public class LlanoAppDbContext(DbContextOptions<LlanoAppDbContext> options) : DbContext(options)
    {
        public DbSet<ResourceTypes> ResourceTypes => Set<ResourceTypes>();
        public DbSet<Resources> Resources => Set<Resources>();
        public DbSet<ResourceStates> ResourceStates => Set<ResourceStates>();
        public DbSet<MessageHistory> MessageHistories => Set<MessageHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResourceTypes>().HasData(
                new ResourceTypes("Leyenda") { Id = 1},
                new ResourceTypes("Palabras") { Id = 2},
                new ResourceTypes("Coplas") { Id = 3},
                new ResourceTypes("Refranes") { Id = 4}
            );
        }
    }
}

