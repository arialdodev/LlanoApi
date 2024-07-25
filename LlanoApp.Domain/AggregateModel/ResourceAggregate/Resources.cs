using LlanoApp.Domain.AggregateModel.Events;
using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class Resources : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string? Image { get; private set; }

        public Resources(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ICollection<MessageHistory> MessageHistory { get; private set; } = [];

        public int ResourceTypesId { get; private set; }
        public ResourceTypes ResourceTypes { get; private set; } = null!;

        public int ResourceStatesId { get; private set; }
        public ResourceStates ResourceStates { get; private set; } = null!;

        public void GetAllResourceTypes()
        {
            this.AddDomainEvent(new ListResourceTypesDomainEvent());
        }

    }
}
