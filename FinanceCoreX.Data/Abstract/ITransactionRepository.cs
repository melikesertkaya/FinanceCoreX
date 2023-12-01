using FinanceCoreX.Core.Entities;
using FinanceCoreX.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Data.Abstract
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
    }
}
