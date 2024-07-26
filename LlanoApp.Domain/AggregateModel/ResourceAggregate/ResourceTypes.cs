using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class ResourceTypes : Entity
    {
        public string TypeName { get; private set; }

        public ResourceTypes(string typeName)
        {
            TypeName = typeName;
        }
            
        public ICollection<Resources> Resources { get; private set; } = [];
    }
}
