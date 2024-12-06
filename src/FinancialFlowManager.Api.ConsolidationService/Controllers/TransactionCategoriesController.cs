using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.ConsolidationService.Controllers;

public class TransactionCategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}