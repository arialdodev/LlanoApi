
namespace LlanoApp.Domain.SeedWork
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task<List<T>> GetAll();
    }
}
