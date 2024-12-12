using FinancialFlowManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinancialFlowManager.Api.ConsolidationService.Configurations
{
    public static class DatabaseConfiguration
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var vaultService = new VaultService(configuration);
            var connectionString = vaultService.GetConnectionStringAsync().Result;

            services.AddDbContext<FinancialFlowContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
