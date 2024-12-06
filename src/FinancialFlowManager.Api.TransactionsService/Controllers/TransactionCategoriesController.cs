using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;

namespace FinancialFlowManager.Api.TransactionsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Protege os endpoints com autenticação JWT
    public class TransactionCategoriesController : ControllerBase
    {
        private readonly ITransactionCategoryAppService _transactionCategoryAppService;

        public TransactionCategoriesController(ITransactionCategoryAppService transactionCategoryAppService)
        {
            _transactionCategoryAppService = transactionCategoryAppService;
        }

        /// <summary>
        /// Retrieves all transaction categories.
        /// </summary>
        /// <returns>List of categories.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _transactionCategoryAppService.GetAllAsync();
            return Ok(categories);
        }

        /// <summary>
        /// Creates a new transaction category.
        /// </summary>
        /// <param name="viewModel">Category data.</param>
        /// <returns>Status of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TransactionCategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _transactionCategoryAppService.CreateAsync(viewModel);
            return CreatedAtAction(nameof(GetAll), null, result);
        }

        /// <summary>
        /// Deletes a transaction category by ID.
        /// </summary>
        /// <param name="id">Category ID.</param>
        /// <returns>Status of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var success = await _transactionCategoryAppService.DeleteAsync(id);

            if (!success)
                return NotFound($"Category with ID {id} not found.");

            return NoContent();
        }
    }
}
