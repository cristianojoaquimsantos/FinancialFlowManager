using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class TransactionCategoryAppService : AppServiceBase<TransactionCategory>, ITransactionCategoryAppService
    {
        protected readonly ITransactionCategoryRepository _transactionCategoryRepository;

        public TransactionCategoryAppService(ITransactionCategoryRepository transactionCategoryRepository) : base(transactionCategoryRepository)
        {
            _transactionCategoryRepository = transactionCategoryRepository;
        }
    }
}
