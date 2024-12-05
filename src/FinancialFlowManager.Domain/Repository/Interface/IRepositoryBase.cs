using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Repository.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity: Entity
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
