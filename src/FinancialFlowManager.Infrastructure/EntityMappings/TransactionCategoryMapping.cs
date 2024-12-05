using FinancialFlowManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialFlowManager.Infrastructure.EntityMappings
{
    public class TransactionCategoryMapping : IEntityTypeConfiguration<TransactionCategory>
    {
        public void Configure(EntityTypeBuilder<TransactionCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
