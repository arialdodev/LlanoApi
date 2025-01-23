using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Enums;
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
                new ResourceTypes("Leyenda") { Id = (int)ResourceTypesEnum.Leyenda},
                new ResourceTypes("Palabra") { Id = (int)ResourceTypesEnum.Palabra},
                new ResourceTypes("Copla") { Id = (int)ResourceTypesEnum.Copla},
                new ResourceTypes("Refran") { Id = (int)ResourceTypesEnum.Refran}
            );
            modelBuilder.Entity<ResourceStates>().HasData(
                new ResourceStates("Solicitado") { Id =  (int)ResourceStatesEnum.Solicitado },
                new ResourceStates("Descartado") { Id = (int)ResourceStatesEnum.Descartado },
                new ResourceStates("Aprobado") { Id = (int)ResourceStatesEnum.Aprobado }
            );
        }
    }
}

