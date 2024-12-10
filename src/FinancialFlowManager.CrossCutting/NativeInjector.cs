using FinancialFlowManager.Application.AppService.Implementation;
using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;
using FinancialFlowManager.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialFlowManager.CrossCutting
{
    public static class NativeInjector
    {
        public static void RegisterInjectorServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //Application
            services.AddScoped<IDailyConsolidationAppService, DailyConsolidationAppService>();
            services.AddScoped<IFinancialAccountAppService, FinancialAccountAppService>();
            services.AddScoped<ILogAuditAppService, LogAuditAppService>();
            services.AddScoped<ITransactionAppService, TransactionAppService>();
            services.AddScoped<ITransactionCategoryAppService, TransactionCategoryAppService>();
            services.AddScoped<IUserAppService, UserAppService>();

            //Repository
            services.AddScoped<IDailyConsolidationRepository, DailyConsolidationRepository>();
            services.AddScoped<IFinancialAccountRepository, FinancialAccountRepository>();
            services.AddScoped<ILogAuditRepository, LogAuditRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITransactionCategoryRepository, TransactionCategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            //Context
            services.AddScoped<FinancialFlowContext>();
        }

    }
}
