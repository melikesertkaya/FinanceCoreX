using FinanceCoreX.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Data.Abstract
{
    public interface IUnitOfWork
    {
        IAccountRepository Accounts { get; }
        IInvoiceRepository Invoices { get; }
        ITransactionRepository Transactions { get; }
        IUserRefreshTokenRepository RefreshTokens { get; }

        Task CommitAsync();

        void Commit();
    }
}
