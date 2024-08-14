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
                new ResourceTypes("Leyenda") { Id = 1},
                new ResourceTypes("Palabra") { Id = 2},
                new ResourceTypes("Copla") { Id = 3},
                new ResourceTypes("Refran") { Id = 4}
            );
            modelBuilder.Entity<ResourceStates>().HasData(
                new ResourceStates("Solicitado") { Id = 1 },
                new ResourceStates("Descartado") { Id = 2 },
                new ResourceStates("Aprobado") { Id = 3 }
            );
        }
    }
}

