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
    public class TransactionService:ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<NoDataResponse> CreateTransaction(Transaction transaction)
        {
            // İşlem oluşturma işlemleri

            await _unitOfWork.Transactions.AddAsync(transaction);
            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success, "İşlem başarıyla oluşturuldu");
        }

        public async Task<Response<List<Transaction>>> GetAllTransactions()
        {
            // Tüm işlemleri alma işlemi
            var transactions = await _unitOfWork.Transactions.GetAllAsync();

            return new Response<List<Transaction>>(ResultStatus.Success, transactions.ToList());
        }

        public async Task<Response<Transaction>> GetTransactionById(int transactionId)
        {
            // Id'ye göre işlem alma işlemi
            var transaction = await _unitOfWork.Transactions.GetAsync(x => x.TransactionId == transactionId);

            return new Response<Transaction>(ResultStatus.Success, transaction);
        }

    }
}
