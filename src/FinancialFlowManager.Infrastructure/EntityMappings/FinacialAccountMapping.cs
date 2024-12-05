using FinancialFlowManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialFlowManager.Infrastructure.EntityMappings
{
    public class FinacialAccountMapping : IEntityTypeConfiguration<FinancialAccount>
    {
        public void Configure(EntityTypeBuilder<FinancialAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}
