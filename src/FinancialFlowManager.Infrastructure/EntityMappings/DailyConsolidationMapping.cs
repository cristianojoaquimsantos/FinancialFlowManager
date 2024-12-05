using FinancialFlowManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialFlowManager.Infrastructure.EntityMappings
{
    public class DailyConsolidationMapping : IEntityTypeConfiguration<DailyConsolidation>
    {
        public void Configure(EntityTypeBuilder<DailyConsolidation> builder)
        {
            throw new NotImplementedException();
        }
    }
}
