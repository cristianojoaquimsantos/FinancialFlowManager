using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class TransactionAppService : AppServiceBase<Transaction>, ITransactionAppService
    {
        protected readonly ITransactionRepository _transactionRepository;

        public TransactionAppService(ITransactionRepository transactionRepository) : base(transactionRepository)
        {
        }
    }
}
