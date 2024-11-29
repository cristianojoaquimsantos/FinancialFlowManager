var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FinancialFlowManager_Api_ConsolidationService>("financialflowmanager-api-consolidationservice");

builder.AddProject<Projects.FinancialFlowManager_Api_TransactionsService>("financialflowmanager-api-transactionsservice");

builder.Build().Run();
