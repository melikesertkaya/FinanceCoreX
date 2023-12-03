using FinanceCoreX.Core.Entities;
using FinanceCoreX.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Services.Abstract
{
    public interface IInvoiceService
    {
        Task<NoDataResponse> CreateInvoice(Invoice invoice);
        Task<Response<List<Invoice>>> GetAllInvoices();
        Task<Response<Invoice>> GetInvoiceById(int invoiceId);
    }
}
