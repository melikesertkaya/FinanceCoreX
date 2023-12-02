using FinanceCoreX.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private AccountRepository _accountRepository;
        private InvoiceRepository _invoiceRepository;
        private TransactionRepository _transactionRepository;
        private UserRefreshTokenRepository _userRefreshTokenRepository;
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }


        public IAccountRepository Accounts => _accountRepository ?? new AccountRepository(_context);

        public IInvoiceRepository Invoices => _invoiceRepository ?? new InvoiceRepository(_context);
        public ITransactionRepository Transactions => _transactionRepository ?? new TransactionRepository(_context);

        public IUserRefreshTokenRepository RefreshTokens => _userRefreshTokenRepository ?? new UserRefreshTokenRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
