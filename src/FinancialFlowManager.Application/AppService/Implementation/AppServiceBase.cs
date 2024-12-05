using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class AppServiceBase<TEntity>: IAppServiceBase<TEntity> where TEntity: Entity
    {
        protected readonly IRepositoryBase<TEntity> _repositoryBase;

        public AppServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
    }
}
