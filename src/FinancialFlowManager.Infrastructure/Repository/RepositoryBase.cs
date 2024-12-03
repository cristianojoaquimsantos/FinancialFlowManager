using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class RepositoryBase<TEntity>: IRepositoryBase<TEntity> where TEntity : Entity
    {

    }
}
