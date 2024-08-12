
using LlanoApp.Domain.SeedWork;

namespace LlanoApp.Domain.AggregateModel.ResourceAggregate
{
    public class MessageHistory : Entity
    {
        public string Message { get; private set; }

        public MessageHistory(string message)
        {
            Message = message;
        }

        public int ResourcesId { get; private set; }
        public Resource Resources { get; private set; } = null!;
    }
}
