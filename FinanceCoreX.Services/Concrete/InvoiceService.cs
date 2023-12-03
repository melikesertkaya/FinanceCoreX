using FinanceCoreX.Core.Entities;
using FinanceCoreX.Data.Abstract;
using FinanceCoreX.Services.Abstract;
using FinanceCoreX.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Services.Concrete
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<NoDataResponse> CreateInvoice(Invoice invoice)
        {
            // Fatura oluşturma işlemleri

            await _unitOfWork.Invoices.AddAsync(invoice);
            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success, "Fatura başarıyla oluşturuldu");
        }

        public async Task<Response<List<Invoice>>> GetAllInvoices()
        {
            // Tüm faturaları alma işlemi
            var invoices = await _unitOfWork.Invoices.GetAllAsync();

            return new Response<List<Invoice>>(ResultStatus.Success, invoices.ToList());
        }

        public async Task<Response<Invoice>> GetInvoiceById(int invoiceId)
        {
            // Id'ye göre fatura alma işlemi
            var invoice = await _unitOfWork.Invoices.GetAsync(x => x.InvoiceId == invoiceId);

            return new Response<Invoice>(ResultStatus.Success, invoice);
        }
    }
    }
