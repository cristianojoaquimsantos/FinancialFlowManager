using FinancialFlowManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialFlowManager.Infrastructure.EntityMappings
{
    public class LogAuditMapping : IEntityTypeConfiguration<LogAudit>
    {
        public void Configure(EntityTypeBuilder<LogAudit> builder)
        {
            throw new NotImplementedException();
        }
    }
}
