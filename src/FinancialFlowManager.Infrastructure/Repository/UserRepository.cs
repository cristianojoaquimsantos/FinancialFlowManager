using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Infrastructure.Context;
using FinancialFlowManager.Infrastructure.Repository;

namespace FinancialFlowManager.Domain.Repository.Interface
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
