using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Core.Events.Interface
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
