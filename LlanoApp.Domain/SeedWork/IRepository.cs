
namespace LlanoApp.Domain.SeedWork
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Create(T entity);
        Task<List<T>> GetAll();
    }
}
