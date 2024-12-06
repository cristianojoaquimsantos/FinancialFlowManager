using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.ConsolidationService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionCategoriesController : ControllerBase
{
    private readonly ITransactionCategoryAppService _transactionCategoryAppService;

    public TransactionCategoriesController(ITransactionCategoryAppService transactionCategoryAppService)
    {
        _transactionCategoryAppService = transactionCategoryAppService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _transactionCategoryAppService.GetAllAsync();
        return Ok(categories);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] TransactionCategoryViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var success = await _transactionCategoryAppService.CreateAsync(viewModel);
        return success ? Ok("Category created successfully.") : StatusCode(500, "Error creating category.");
    }
}
