# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY src/FinancialFlowManager.Api.TransactionsService/FinancialFlowManager.Api.TransactionsService.csproj src/FinancialFlowManager.Api.TransactionsService/
COPY src/FinancialFlowManager.Application/FinancialFlowManager.Application.csproj FinancialFlowManager.Application/
COPY src/FinancialFlowManager.Domain/FinancialFlowManager.Domain.csproj FinancialFlowManager.Domain/
COPY src/FinancialFlowManager.Domain.Core/FinancialFlowManager.Domain.Core.csproj FinancialFlowManager.Domain.Core/
COPY src/FinancialFlowManager.Infrastructure/FinancialFlowManager.Infrastructure.csproj FinancialFlowManager.Infrastructure/
COPY src/FinancialFlowManager.CrossCutting/FinancialFlowManager.CrossCutting.IoC.csproj FinancialFlowManager.CrossCutting.IoC/
COPY src/FinancialFlowManager.Infra.Identity/FinancialFlowManager.Infra.Identity.csproj FinancialFlowManager.Infra.Identity/

RUN dotnet restore "./src/FinancialFlowManager.Api.TransactionsService/FinancialFlowManager.Api.TransactionsService.csproj"
COPY . .
WORKDIR "/src/src/FinancialFlowManager.Api.TransactionsService"
RUN dotnet build "./FinancialFlowManager.Api.TransactionsService.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FinancialFlowManager.Api.TransactionsService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinancialFlowManager.Api.TransactionsService.dll"]