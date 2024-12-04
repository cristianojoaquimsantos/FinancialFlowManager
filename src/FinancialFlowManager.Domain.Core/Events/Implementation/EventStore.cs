using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Core.Events.Implementation
{
    public class EventStore : Event
    {
        public EventStore(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            Data = data;
            User = user;
        }

        public Guid Id { get; private set; }
        public string Data { get; private set; }
        public string User { get; private set; }
    }
}
