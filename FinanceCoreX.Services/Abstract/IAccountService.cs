using FinanceCoreX.Core.Entities;
using FinanceCoreX.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Services.Abstract
{
    public interface IAccountService
    {
        Task<NoDataResponse> CreateAccount(Account account);
        Task<Response<List<Account>>> GetAllAccounts();
        Task<Response<Account>> GetAccountById(int accountId);
    }
}
