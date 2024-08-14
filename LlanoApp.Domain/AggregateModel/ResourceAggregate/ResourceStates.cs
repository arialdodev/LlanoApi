using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class ResourceStates : Entity
    {
        public string NameState { get; private set; }

        public ResourceStates(string nameState)
        {
            NameState = nameState;
        }

        public ICollection<Resource> Resources { get; private set; } = [];
    }
}
