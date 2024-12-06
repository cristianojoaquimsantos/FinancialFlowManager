using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.ConsolidationService.Controllers;

public class FinancialAccountsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}