﻿using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class FinancialAccountAppService : AppServiceBase<FinancialAccount>, IFinancialAccountAppService
    {
        protected readonly IFinancialAccountRepository _financialAccountRepository;

        public FinancialAccountAppService(IFinancialAccountRepository financialAccountRepository) : base(financialAccountRepository)
        {
            _financialAccountRepository = financialAccountRepository;
        }
    }
}