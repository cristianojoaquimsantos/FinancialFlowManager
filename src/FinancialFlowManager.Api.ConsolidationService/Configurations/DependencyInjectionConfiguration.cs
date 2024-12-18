﻿using FinancialFlowManager.CrossCutting;

namespace FinancialFlowManager.Api.ConsolidationService.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjector.RegisterInjectorServices(services);
        }
    }
}
