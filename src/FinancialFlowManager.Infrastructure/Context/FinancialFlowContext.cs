using FinancialFlowManager.Domain.Core.Data;
using FinancialFlowManager.Domain.Core.Mediator;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Infrastructure.EntityMappings;
using FinancialFlowManager.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace FinancialFlowManager.Infrastructure.Context
{
    public class FinancialFlowContext: DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatonHandler;

        public FinancialFlowContext(DbContextOptions<FinancialFlowContext> options, IMediatorHandler mediatorHandler)
        {
            _mediatonHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<DailyConsolidation> DailyConsolidation { get; set; }
        public DbSet<LogAudit> LogAudit { get; set; }
        public DbSet<TransactionCategory> TransactionCategory { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<FinancialAccount> FinancialAccount { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DailyConsolidationMapping());
            modelBuilder.ApplyConfiguration(new FinacialAccountMapping());
            modelBuilder.ApplyConfiguration(new LogAuditMapping());
            modelBuilder.ApplyConfiguration(new TransactionCategoryMapping());
            modelBuilder.ApplyConfiguration(new TransactionMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());


            base.OnModelCreating(modelBuilder);            
        }

        public async Task<bool> Commit()
        {
            await _mediatonHandler.PublishDomainEvents(this).ConfigureAwait(false);
            var sucess = await SaveChangesAsync() > 0;

            return sucess;
        }
    }
}
