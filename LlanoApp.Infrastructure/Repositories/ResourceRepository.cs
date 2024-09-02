using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Repositories
{
    public class ResourceRepository : IRepository<Resource>
    {
        private readonly LlanoAppDbContext _llanoAppDbContext;

        public ResourceRepository(LlanoAppDbContext llanoAppDbContext)
        {
            _llanoAppDbContext = llanoAppDbContext;
        }

        public async Task<bool> Create(Resource resource)
        {
            await _llanoAppDbContext.Resource.AddAsync(resource);
            await _llanoAppDbContext.SaveChangesAsync();
            return true;            
        }

        public Task<List<Resource>> GetAll()
        {
            var resourcesList = _llanoAppDbContext.Resource.ToListAsync();
            return resourcesList;
        }
    }
}
