using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class UserValidation<T>: AbstractValidator<T> where T : UserCommand
    {
    }
}
