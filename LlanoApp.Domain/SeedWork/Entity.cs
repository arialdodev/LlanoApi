using MediatR;

namespace LlanoApp.Domain.SeedWork
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime UpdateDate { get; private set; }
        public DateTime CreateDate { get; private set; }

        private List<INotification> _domainEvents;

        protected Entity()
        {
            UpdateDate = DateTime.Now;
            CreateDate = DateTime.Now;
            _domainEvents = new List<INotification>();
        }
        public void SetUpdateDate()
        {
            UpdateDate = DateTime.UtcNow;
        }

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

    }
}
