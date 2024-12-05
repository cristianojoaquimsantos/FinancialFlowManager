using FinancialFlowManager.Domain.Core.Data;
using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class RepositoryBase<TEntity>: IDisposable, IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly FinancialFlowContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(FinancialFlowContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public async void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
