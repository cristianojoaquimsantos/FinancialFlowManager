using FluentValidation;

namespace FinancialFlowManager.Domain.Commands.Validations
{
    public abstract class LogAuditValidation<T> : AbstractValidator<T> where T: LogAuditCommand
    {
    }
}
