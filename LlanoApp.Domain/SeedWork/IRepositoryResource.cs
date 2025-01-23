using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;

namespace LlanoApp.Domain.SeedWork
{
    public interface IRepositoryResource<T> where T : class
    {
        Task<Result<bool>> Create(T entity);
        Task<Result<List<Resource>>> GetAllByResourceTypeId(int? resourceTypeId);

        // Actualizar
        Task<Result<T>> GetById(int id);
        Task<Result<T>> Update(T entity);
    }
}