using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LlanoApp.Infrastructure.Repositories
{
    public class ResourceRepository : IRepositoryResource<Resource>
    {
        private readonly LlanoAppDbContext _llanoAppDbContext;

        public ResourceRepository(LlanoAppDbContext llanoAppDbContext)
        {
            _llanoAppDbContext = llanoAppDbContext;
        }

        public async Task<Result<bool>> Create(Resource resource)
        {
            await _llanoAppDbContext.Resource.AddAsync(resource);
            await _llanoAppDbContext.SaveChangesAsync();
            return Result<bool>.Success(true);
        }

        public async Task<Result<List<Resource>>> GetAllByResourceTypeId(int? resourceTypeId)
        {
            try
            {
                List<Resource> resourcesList;

                if (resourceTypeId.HasValue)
                {
                    resourcesList = await _llanoAppDbContext.Resource
                        .Where(x => x.ResourceTypesId == resourceTypeId.Value)
                        .ToListAsync();
                }
                else
                {
                    resourcesList = await _llanoAppDbContext.Resource
                        .ToListAsync();
                }

                return Result<List<Resource>>.Success(resourcesList);
            }
            catch (Exception ex)
            {
                return Result<List<Resource>>.Failure($"Error al obtener los recursos: {ex.Message}", ErrorType.Unknown);
            }
        }
        public Task<Resource?> GetById(int id)
        {
            return _llanoAppDbContext.Set<Resource>().FirstOrDefaultAsync(r => r.Id == id);
        }

        public void Update(Resource resource)
        {
            _llanoAppDbContext.Resource.Update(resource);
            _llanoAppDbContext.SaveChanges();
        }
    }
}