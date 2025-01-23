
namespace LlanoApp.Domain.SeedWork
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Create(T entity);
        Task<List<T>> GetAll();

        // Actualizar
        Task<T?> GetById(int id);
        void Update(T entity);
    }
}