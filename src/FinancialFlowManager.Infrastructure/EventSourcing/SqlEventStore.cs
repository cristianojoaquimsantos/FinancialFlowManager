using FinancialFlowManager.Domain.Core.Events.Implementation;
using FinancialFlowManager.Domain.Core.Events.Interface;
using FinancialFlowManager.Domain.Core.Messaging;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.EventSourcing.Interface;
using FinancialFlowManager.Infra.Identity.User.Interface;
using Newtonsoft.Json;

namespace FinancialFlowManager.Infrastructure.EventSourcing
{
    public class SqlEventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IAspNetUser _user;

        public SqlEventStore(IEventStoreRepository eventStoreRepository, IAspNetUser user)
        {
            _eventStoreRepository = eventStoreRepository;
            _user = user;
        }



        public void Save<T>(T theEvent) where T : Event
        {
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new EventStore(
            theEvent,
            serializedData,
            _user.Name ?? _user.GetUserEmail());

            _eventStoreRepository.Store(storedEvent);
        }
    }
}
