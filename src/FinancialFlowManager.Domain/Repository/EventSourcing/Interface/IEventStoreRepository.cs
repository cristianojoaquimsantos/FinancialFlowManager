using FinancialFlowManager.Domain.Core.Events.Implementation;

namespace FinancialFlowManager.Domain.Repository.EventSourcing.Interface
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(EventStore theEvent);
        Task<IList<EventStore>> All(Guid aggregateId);
    }
}
