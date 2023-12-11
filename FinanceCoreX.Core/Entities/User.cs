using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FinanceCoreX.Core.Entities
{
    public class User : IdentityUser
    {
        public bool IsAdmin { get; set; } = false;
        public decimal Balance { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
