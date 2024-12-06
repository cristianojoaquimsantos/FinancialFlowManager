using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class UserCommand: Command
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
    }
}
