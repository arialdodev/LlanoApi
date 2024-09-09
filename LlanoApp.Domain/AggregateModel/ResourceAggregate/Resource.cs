using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class Resource : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

        public Resource(string name, string description,string image ,int resourceTypesId, int resourceStatesId)
        {
            Name = name;
            Description = description;  
            ResourceTypesId = resourceTypesId;
            ResourceStatesId = resourceStatesId;
            Image = image;
        }

        public void Update(string description, string name)
        {
            Description = description;
            Name = name;
        }

        public ICollection<MessageHistory> MessageHistory { get; private set; } = [];

        public int ResourceTypesId { get; private set; }
        public ResourceTypes ResourceTypes { get; private set; } = null!;

        public int ResourceStatesId { get; private set; } 
        public ResourceStates ResourceStates { get; private set; } = null!;

        //public void GetAllResourceTypes()
        //{
        //    this.AddDomainEvent(new ListResourceTypesDomainEvent());
        //}

    }
}
