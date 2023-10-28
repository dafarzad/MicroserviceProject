

namespace EventBus.Message.Events
{
    public class IntegrationBaseEvent
    {
        public IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public IntegrationBaseEvent(Guid id, DateTime myProperty)
        {
            Id = id;
            CreationDate = myProperty;
        }

        public Guid Id { get; }
        public DateTime CreationDate { get; }
    }
}
