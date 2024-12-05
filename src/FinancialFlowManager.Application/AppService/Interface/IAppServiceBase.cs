using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Application.AppService.Interface
{
    internal interface IAppServiceBase<TEntity> where TEntity: Entity
    {
    }
}
