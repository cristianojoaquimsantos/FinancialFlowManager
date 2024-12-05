using FinancialFlowManager.Domain.Core.Events.Implementation;
using FinancialFlowManager.Domain.Repository.EventSourcing.Interface;

namespace FinancialFlowManager.Infrastructure.Repository.EventSourcing.Implementation
{
    public class EventStoreRepository : IEventStoreRepository
    {
        public EventStoreRepository(EventStoreRepository contage)
        {
            
        }

        public Task<IList<EventStore>> All(Guid aggregateId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Store(EventStore theEvent)
        {
            throw new NotImplementedException();
        }
    }
}
