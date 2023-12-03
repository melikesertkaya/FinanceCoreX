using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceCoreX.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            var response = await _invoiceService.CreateInvoice(invoice);
            return Ok(response);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllInvoices()
        {
            var response = await _invoiceService.GetAllInvoices();
            return Ok(response);
        }

        [HttpGet("{invoiceId}")]
        public async Task<IActionResult> GetInvoiceById(int invoiceId)
        {
            var response = await _invoiceService.GetInvoiceById(invoiceId);
            if (response.Data == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
