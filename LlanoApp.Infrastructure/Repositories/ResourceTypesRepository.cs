using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Repositories
{
    public class ResourceTypesRepository(LlanoAppDbContext llanoAppDbContext) : IRepository<ResourceTypes>
    {
        private readonly LlanoAppDbContext _llanoAppDbContext = llanoAppDbContext;


        public void Add(ResourceTypes entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceTypes>> GetAll()
        {
            var listResourceTypes = _llanoAppDbContext.ResourceTypes.ToListAsync();
            return listResourceTypes;
        }
    }
}
