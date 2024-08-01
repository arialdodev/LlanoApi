using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class ResourceStates : Entity
    {
        public string State { get; private set; }

        public ResourceStates(string state)
        {
            State = state;
        }

        public ICollection<Resource> Resources { get; private set; } = [];
    }
}
