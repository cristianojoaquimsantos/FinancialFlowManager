using AutoMapper;
using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Application.ViewModels;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class DailyConsolidationAppService : AppServiceBase<DailyConsolidation>, IDailyConsolidationAppService
    {
        protected readonly IDailyConsolidationRepository _dailyConsolidationRepository;
        private readonly IMapper _mapper;

        public DailyConsolidationAppService(IDailyConsolidationRepository dailyConsolidationRepository) : base(dailyConsolidationRepository)
        {
            _dailyConsolidationRepository = dailyConsolidationRepository;
        }

        public async Task<DailyConsolidationViewModel?> GetConsolidatedBalanceByDateAsync(DateTime date)
        {
            // Step 1: Validate input
            if (date == default)
                throw new ArgumentException("Invalid date provided.");

            // Step 2: Query the repository
            var consolidation = await _dailyConsolidationRepository.GetByDateAsync(date);

            // Step 3: Process the result
            if (consolidation == null)
                return null;

            // Step 4: Map domain entity to view model
            return _mapper.Map<DailyConsolidationViewModel>(consolidation);
        }


        public async Task<bool> UpdateConsolidatedBalanceAsync(UpdateDailyConsolidationViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CalculateConsolidatedBalanceAsync()
        {
            throw new NotImplementedException();
        }
    }
}
