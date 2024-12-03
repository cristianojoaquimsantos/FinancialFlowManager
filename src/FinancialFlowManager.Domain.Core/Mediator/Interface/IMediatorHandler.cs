using FinancialFlowManager.Domain.Core.Messaging;
using FluentValidation.Results;


namespace FinancialFlowManager.Domain.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
