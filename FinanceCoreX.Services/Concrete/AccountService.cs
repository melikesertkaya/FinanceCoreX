using FinanceCoreX.Core.Entities;
using FinanceCoreX.Core.Repository;
using FinanceCoreX.Data.Abstract;
using FinanceCoreX.Services.Abstract;
using FinanceCoreX.Shared.Response;
using Microsoft.AspNetCore.Identity;

namespace FinanceCoreX.Services.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public AccountService(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<NoDataResponse> CreateAccount(Account account)
        {
            // Account oluşturma işlemleri

            await _unitOfWork.Accounts.AddAsync(account);
            await _unitOfWork.CommitAsync();

            return new NoDataResponse(ResultStatus.Success, "Hesap başarıyla oluşturuldu");
        }

        public async Task<Response<List<Account>>> GetAllAccounts()
        {
            // Tüm hesapları alma işlemi
            var accounts = await _unitOfWork.Accounts.GetAllAsync();

            return new Response<List<Account>>(ResultStatus.Success, accounts.ToList());
        }

        public async Task<Response<Account>> GetAccountById(int accountId)
        {
            // Id'ye göre hesap alma işlemi
            var account = await _unitOfWork.Accounts.GetAsync(x => x.AccountId == accountId);

            return new Response<Account>(ResultStatus.Success, account);
        }
    }
}