using MediatR;

namespace FinancialFlowManager.Domain.Core.Messaging
{
    public abstract class Event: Message, INotification
    {
        protected Event()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; set; }
    }
}
