using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinancialFlowManager.Api.ConsolidationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsolidationsController : ControllerBase
    {
        private readonly IDailyConsolidationAppService _dailyConsolidationAppService;

        public ConsolidationsController(IDailyConsolidationAppService dailyConsolidationAppService)
        {
            _dailyConsolidationAppService = dailyConsolidationAppService;
        }

        /// <summary>
        /// Retrieves the daily consolidated balance for a specific date.
        /// </summary>
        /// <param name="date">The date to retrieve the consolidated balance for.</param>
        /// <returns>A consolidated balance object.</returns>
        [HttpGet("{date}")]
        public async Task<IActionResult> GetConsolidatedBalanceByDate([FromRoute] DateTime date)
        {
            var result = await _dailyConsolidationAppService.GetConsolidatedBalanceByDateAsync(date);
            if (result == null)
                return NotFound($"No consolidated data found for the date: {date:yyyy-MM-dd}");

            return Ok(result);
        }

        /// <summary>
        /// Updates the consolidated balance for a specific date.
        /// </summary>
        /// <param name="viewModel">Updated consolidation details.</param>
        /// <returns>Status of the update operation.</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateConsolidatedBalance([FromBody] UpdateDailyConsolidationViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _dailyConsolidationAppService.UpdateConsolidatedBalanceAsync(viewModel);
            if (!success)
                return StatusCode(500, "An error occurred while updating the consolidated balance.");

            return NoContent(); // 204 No Content
        }

        /// <summary>
        /// Calculates and stores the daily consolidated balance.
        /// </summary>
        /// <returns>Status of the calculation operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CalculateConsolidatedBalance()
        {
            var success = await _dailyConsolidationAppService.CalculateConsolidatedBalanceAsync();
            if (!success)
                return StatusCode(500, "An error occurred while calculating the consolidated balance.");

            return Ok("Daily consolidated balance calculated successfully.");
        }
    }
}
