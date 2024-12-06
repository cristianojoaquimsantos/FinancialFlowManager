using AutoMapper;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Application.AutoMapper;

public class DomainToViewModelProfile: Profile
{
    public DomainToViewModelProfile()
    {
        CreateMap<DailyConsolidation, DailyConsolidationViewModel>().ReverseMap();
        CreateMap<FinancialAccount, FinancialAccountViewModel>().ReverseMap();
        CreateMap<LogAudit, LogAuditViewModel>().ReverseMap();
        CreateMap<Transaction, TransactionViewModel>().ReverseMap();
        CreateMap<TransactionCategory, TransactionCategoryViewModel>().ReverseMap();
        CreateMap<User, UserViewModel>().ReverseMap();
    }
}