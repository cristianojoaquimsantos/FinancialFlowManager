using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class TypeFinancialAccountRepository : RepositoryBase<TypeFinancialAccount>, ITypeFinancialAccountRepository
    {
        protected readonly FinancialFlowContext _context;

        public TypeFinancialAccountRepository(FinancialFlowContext context) : base(context)
        {
            _context = context;
        }
    }
}
