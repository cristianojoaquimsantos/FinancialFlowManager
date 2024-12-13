using FinancialFlowManager.Api.ConsolidationService.Configurations;
using FinancialFlowManager.Infrastructure.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configuração de autenticação JWT
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "https://api.financialflowmanager.com",
                    ValidAudience = "https://app.financialflowmanager.com",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("_OHqpDm5j0F1VwoT-wlcPquFK1rKhicxVduGrAXoOB_7uwGp5CVInfED5l_xt8F5SflUEDGX62i-s7XOsn4-MA"))
                };
            });

        builder.Services.AddAuthorization();

        // Configuração de serviços e middlewares
        builder.AddServiceDefaults();
        builder.Services.AddDependencyInjectionConfiguration();
        builder.Services.AddSwaggerConfiguration();
        builder.Services.AddDatabaseConfiguration(builder.Configuration);

        // Adiciona controladores e outras configurações
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapDefaultEndpoints();

        // Configuração do pipeline HTTP
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
