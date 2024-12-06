using FinancialFlowManager.Domain.Commands.RegisterCommand;
using FinancialFlowManager.Domain.Core.Messaging;
using FluentValidation.Results;
using MediatR;

namespace FinancialFlowManager.Domain.Commands.Handlers
{
    public class DailyConsolidationCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewDailyConsolidationCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(RegisterNewDailyConsolidationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
