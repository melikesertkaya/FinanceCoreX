using FinanceCoreX.Core.Entities;
using FinanceCoreX.Shared.Response;

namespace FinanceCoreX.Services.Abstract
{
    public interface ITransactionService
    {
        Task<NoDataResponse> CreateTransaction(Transaction transaction);
        Task<Response<List<Transaction>>> GetAllTransactions();
        Task<Response<Transaction>> GetTransactionById(int transactionId);
    }
}
