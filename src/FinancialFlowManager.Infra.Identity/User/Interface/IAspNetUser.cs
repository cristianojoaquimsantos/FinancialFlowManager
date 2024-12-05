﻿using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace FinancialFlowManager.Infra.Identity.User.Interface
{
    public interface IAspNetUser
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        bool IsAutenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetUserClaims();
        HttpContext GetHttpContext();
    }
}
