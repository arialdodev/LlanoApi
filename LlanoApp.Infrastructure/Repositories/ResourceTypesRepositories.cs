using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Infrastructure.Persistence;

namespace LlanoApp.Infrastructure.Repositories
{
    public class ResourceTypesRepositories(LlanoAppDbContext llanoAppDbContext) : IResourceTypesRepository
    {
        private readonly LlanoAppDbContext _llanoAppDbContext = llanoAppDbContext;

        public async Task<IQueryable<ResourceTypes>> Search(string? typeName)   
        {
            IQueryable<ResourceTypes> resourceTypes = _llanoAppDbContext.ResourceTypes;

            if (!string.IsNullOrEmpty(typeName))
            {
                resourceTypes = resourceTypes.Where(rt => rt.TypeName!.Contains(typeName));
            }

            return await Task.FromResult(resourceTypes);
        }

    }
}
