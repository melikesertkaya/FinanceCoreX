using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceCoreX.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAccount([FromBody] Account account)
        {
            var response = await _accountService.CreateAccount(account);
            return Ok(response);
        }
        [Authorize]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllAccounts()
        {
            var response = await _accountService.GetAllAccounts();
            return Ok(response);
        }

        [HttpGet("{accountId}")]
        public async Task<IActionResult> GetAccountById(int accountId)
        {
            var response = await _accountService.GetAccountById(accountId);
            if (response.Data == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

    }
}