using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FinancialAccountsController : ControllerBase
{
    private readonly IFinancialAccountAppService _financialAccountAppService;

    public FinancialAccountsController(IFinancialAccountAppService financialAccountAppService)
    {
        _financialAccountAppService = financialAccountAppService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAccounts()
    {
        var accounts = await _financialAccountAppService.GetAllAsync();
        return Ok(accounts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAccountById(Guid id)
    {
        var account = await _financialAccountAppService.GetByIdAsync(id);
        if (account == null)
            return NotFound("Account not found.");

        return Ok(account);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccount([FromBody] FinancialAccountViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var success = await _financialAccountAppService.CreateAsync(viewModel);
        return success ? Ok("Account created successfully.") : StatusCode(500, "Error creating account.");
    }
}