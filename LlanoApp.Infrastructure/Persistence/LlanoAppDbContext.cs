using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LlanoApp.Infrastructure.Persistence
{
    public class LlanoAppDbContext : DbContext
    {
        private readonly string _connectionString;

        public LlanoAppDbContext(IOptions<DatabaseOptions> options, DbContextOptions<LlanoAppDbContext> dbContextOptions)
        : base(dbContextOptions)
        {
            _connectionString = options.Value.DbConnection;
        }

        public DbSet<ResourceTypes> ResourceTypes => Set<ResourceTypes>();
        public DbSet<Resource> Resource => Set<Resource>();
        public DbSet<ResourceStates> ResourceStates => Set<ResourceStates>();
        public DbSet<MessageHistory> MessageHistories => Set<MessageHistory>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

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

