
namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public interface IResourceTypesRepository
    {
        public Task<IQueryable<ResourceTypes>> Search(string? typeName);
    }
}
