using AutoMapper;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Application.AutoMapper;

public class ViewModelToDomainProfile: Profile
{
    public ViewModelToDomainProfile()
    {
        CreateMap<DailyConsolidationViewModel, DailyConsolidation>().ReverseMap();
        CreateMap<FinancialAccountViewModel, FinancialAccount>().ReverseMap();
        CreateMap<LogAuditViewModel, LogAudit>().ReverseMap();
        CreateMap<TransactionViewModel, Transaction>().ReverseMap();
        CreateMap<TransactionCategoryViewModel, TransactionCategory>().ReverseMap();
        CreateMap<UserViewModel, User>().ReverseMap();
    }
}