using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var listResourceStates = _llanoAppDbContext.ResourceStates.ToListAsync();
            return listResourceStates;
        }
    }
}
