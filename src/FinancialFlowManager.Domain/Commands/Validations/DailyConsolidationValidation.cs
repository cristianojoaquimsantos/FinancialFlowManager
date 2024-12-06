using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class DailyConsolidationValidation<T> : AbstractValidator<T> where T: DailyConsolidationCommand
    {
    }
}
