using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Protege os endpoints com autenticação JWT
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionAppService _transactionAppService;

        public TransactionsController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        /// <summary>
        /// Retrieves all transactions with optional filtering.
        /// </summary>
        /// <param name="startDate">Start date for filtering (optional).</param>
        /// <param name="endDate">End date for filtering (optional).</param>
        /// <returns>List of transactions.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            var transactions = await _transactionAppService.GetAllAsync(startDate, endDate);
            return Ok(transactions);
        }

        /// <summary>
        /// Retrieves a specific transaction by ID.
        /// </summary>
        /// <param name="id">Transaction ID.</param>
        /// <returns>Transaction details.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var transaction = await _transactionAppService.GetByIdAsync(id);

            if (transaction == null)
                return NotFound($"Transaction with ID {id} not found.");

            return Ok(transaction);
        }

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="viewModel">Transaction data.</param>
        /// <returns>Status of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TransactionViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _transactionAppService.CreateAsync(viewModel);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        /// <summary>
        /// Updates an existing transaction.
        /// </summary>
        /// <param name="id">Transaction ID.</param>
        /// <param name="viewModel">Updated transaction data.</param>
        /// <returns>Status of the operation.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] TransactionViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _transactionAppService.UpdateAsync(id, viewModel);

            if (!success)
                return NotFound($"Transaction with ID {id} not found.");

            return NoContent();
        }

        /// <summary>
        /// Deletes a transaction by ID.
        /// </summary>
        /// <param name="id">Transaction ID.</param>
        /// <returns>Status of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var success = await _transactionAppService.DeleteAsync(id);

            if (!success)
                return NotFound($"Transaction with ID {id} not found.");

            return NoContent();
        }
    }
}
