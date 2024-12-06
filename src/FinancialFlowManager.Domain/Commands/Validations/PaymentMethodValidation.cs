using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class PaymentMethodValidation<T>: AbstractValidator<T> where T: PaymentMethodCommand
    {
    }
}
