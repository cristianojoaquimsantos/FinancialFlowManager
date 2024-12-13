# Base image para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Stage para construir o projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar arquivos de projeto com caminhos relativos
COPY src/FinancialFlowManager.Api.ConsolidationService/FinancialFlowManager.Api.ConsolidationService.csproj FinancialFlowManager.Api.ConsolidationService/
COPY src/FinancialFlowManager.Application/FinancialFlowManager.Application.csproj FinancialFlowManager.Application/
COPY src/FinancialFlowManager.Domain/FinancialFlowManager.Domain.csproj FinancialFlowManager.Domain/
COPY src/FinancialFlowManager.Domain.Core/FinancialFlowManager.Domain.Core.csproj FinancialFlowManager.Domain.Core/
COPY src/FinancialFlowManager.Infrastructure/FinancialFlowManager.Infrastructure.csproj FinancialFlowManager.Infrastructure/
COPY src/FinancialFlowManager.CrossCutting/FinancialFlowManager.CrossCutting.IoC.csproj FinancialFlowManager.CrossCutting.IoC/
COPY src/FinancialFlowManager.Infra.Identity/FinancialFlowManager.Infra.Identity.csproj FinancialFlowManager.Infra.Identity/

# Restaurar dependências do projeto principal
RUN dotnet restore FinancialFlowManager.Api.ConsolidationService/FinancialFlowManager.Api.ConsolidationService.csproj

# Copiar o restante dos arquivos
COPY src .

# Build do projeto
WORKDIR /src/FinancialFlowManager.Api.ConsolidationService
RUN dotnet build FinancialFlowManager.Api.ConsolidationService.csproj -c $BUILD_CONFIGURATION -o /app/build

# Stage para publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish FinancialFlowManager.Api.ConsolidationService.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Stage final para produção
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinancialFlowManager.Api.ConsolidationService.dll"]
