using FinancialFlowManager.Domain.Core.Messaging;
using FluentValidation.Results;
using MediatR;

namespace FinancialFlowManager.Domain.Core.Mediator.Implementation
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator) => _mediator = mediator;
        public async Task PublishEvent<T>(T @event) where T : Event 
            => await _mediator.Publish(@event, new CancellationToken());

        public async Task<ValidationResult> SendCommand<T>(T command) where T : Command
            => await _mediator.Send((IRequest<ValidationResult>)command, new CancellationToken());
    }
}
