using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.ConsolidationService.Controllers;

public class ConsolidationsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}