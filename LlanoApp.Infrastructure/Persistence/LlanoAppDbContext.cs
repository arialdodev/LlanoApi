using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Persistence
{
    public class LlanoAppDbContext(DbContextOptions<LlanoAppDbContext> options) : DbContext(options)
    {
        public DbSet<ResourceTypes> ResourceTypes => Set<ResourceTypes>();
        public DbSet<Resource> Resource => Set<Resource>();
        public DbSet<ResourceStates> ResourceStates => Set<ResourceStates>();
        public DbSet<MessageHistory> MessageHistories => Set<MessageHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResourceTypes>().HasData(
                new ResourceTypes("Legend") { Id = 1},
                new ResourceTypes("word") { Id = 2},
                new ResourceTypes("couplet") { Id = 3},
                new ResourceTypes("proverb") { Id = 4}
            );
            modelBuilder.Entity<ResourceStates>().HasData(
                new ResourceStates("requested") { Id = 1 },
                new ResourceStates("rejected") { Id = 2 },
                new ResourceStates("approved") { Id = 3 }
            );
        }
    }
}

