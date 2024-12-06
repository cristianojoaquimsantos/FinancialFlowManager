using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class TransactionValidation<T>: AbstractValidator<T> where T: TransactionCommand
    {
    }
}
