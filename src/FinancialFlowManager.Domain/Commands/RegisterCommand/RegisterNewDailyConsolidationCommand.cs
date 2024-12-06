using FinancialFlowManager.Domain.Commands.Validations.RegisterVaidations;

namespace FinancialFlowManager.Domain.Commands.RegisterCommand
{
    public class RegisterNewDailyConsolidationCommand(DateTime date,
                                                      decimal openingBalance,
                                                      decimal totalCredits,
                                                      decimal totalDebits,
                                                      decimal closingBalance) : DailyConsolidationCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RegisterNewDailyConsolidationValidation().Validate(this);
            return base.IsValid();
        }
    }
}
