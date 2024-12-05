using FinancialFlowManager.Domain.Core.Events.Implementation;

namespace FinancialFlowManager.Infrastructure.Repository.EventSourcing.Interface
{
    public interface IEventStoreRepository: IDisposable
    {
        void Store(EventStore theEvent);
        Task<IList<EventStore>> All(Guid aggregateId);
    }
}
