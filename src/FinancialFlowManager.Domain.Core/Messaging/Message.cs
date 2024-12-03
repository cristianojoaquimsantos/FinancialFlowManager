namespace FinancialFlowManager.Domain.Core.Messaging
{
    public abstract class Message
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; } = Guid.NewGuid();

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
