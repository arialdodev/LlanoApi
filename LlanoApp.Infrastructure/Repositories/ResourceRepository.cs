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
            catch (Exception)
            {
                return Result<List<Resource>>.Failure("Error al obtener los recursos", ErrorType.NotFound);
            }
        }
        public async Task<Result<Resource>> GetById(int id)
        {
            try
            {
                var entity = await _llanoAppDbContext.Set<Resource>().FirstOrDefaultAsync(r => r.Id == id);

                if (entity is null)
                {
                    return Result<Resource>.Failure("Entidad no encontrada.", ErrorType.NotFound);
                }
                return Result<Resource>.Success(entity);

            }
            catch (Exception)
            {
                return Result<Resource>.Failure("error al recuperar la entidad", ErrorType.NotFound);
            }
        }

        public async Task<Result<Resource>> Update(Resource resource)
        {
            try 
            {
                _llanoAppDbContext.Resource.Update(resource);
                await _llanoAppDbContext.SaveChangesAsync();

                return Result<Resource>.Success(resource);
            }
            catch (Exception) 
            {
                return Result<Resource>.Failure("Error updating resource", ErrorType.NotFound);
            }
        }
    }
}