using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        protected new readonly FinancialFlowContext Db;

        public UserRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }
    }
}
