using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class TransactionCategoryValidation<T> : AbstractValidator<T> where T: TransactionCategoryCommand
    {
    }
}
