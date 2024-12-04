namespace FinancialFlowManager.Domain.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
