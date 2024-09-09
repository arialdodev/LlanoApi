using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Repositories
{
    public class ResourceStatesRepository(LlanoAppDbContext llanoAppDbContext) : IRepository<ResourceStates>
    {
        private readonly LlanoAppDbContext _llanoAppDbContext = llanoAppDbContext;
        public Task<bool> Create(ResourceStates entity)
        {
            throw new NotImplementedException();
        }
        public Task<List<ResourceStates>> GetAll()
        {
            var resourceStatesList = _llanoAppDbContext.ResourceStates.ToListAsync();
            return resourceStatesList;
        }

        public Task<ResourceStates?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ResourceStates entity)
        {
            throw new NotImplementedException();
        }
    }
}
