using FinancialFlowManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialFlowManager.Infrastructure.EntityMappings
{
    public class TypeFinancialAccountMapping : IEntityTypeConfiguration<TypeFinancialAccount>
    {
        public void Configure(EntityTypeBuilder<TypeFinancialAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}
