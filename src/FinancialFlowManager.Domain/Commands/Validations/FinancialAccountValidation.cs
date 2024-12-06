using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class FinancialAccountValidation<T>: AbstractValidator<T> where T: FinancialAccountCommand
    {
    }
}
