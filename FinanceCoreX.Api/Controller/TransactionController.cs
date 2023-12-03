using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceCoreX.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTransaction([FromBody] Transaction transaction)
        {
            var response = await _transactionService.CreateTransaction(transaction);
            return Ok(response);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllTransactions()
        {
            var response = await _transactionService.GetAllTransactions();
            return Ok(response);
        }

        [HttpGet("{transactionId}")]
        public async Task<IActionResult> GetTransactionById(int transactionId)
        {
            var response = await _transactionService.GetTransactionById(transactionId);
            if (response.Data == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
