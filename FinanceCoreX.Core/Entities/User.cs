using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FinanceCoreX.Core.Entities
{
    public class User : IdentityUser<string>
    {
        [Required]
        public string City { get; set; }
        public bool IsAdmin { get; set; } = false;
        public decimal Balance { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
