using FinanceCoreX.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts"); // Tablo adı
            builder.HasKey(a => a.AccountId); // Primary key belirleme

            builder.Property(a => a.AccountId).HasColumnName("AccountId"); // Sütun adı ve özellikleri
            builder.Property(a => a.UserId).HasColumnName("UserId");
            builder.Property(a => a.Balance).HasColumnName("Balance");
            builder.Property(a => a.AccountType).HasColumnName("AccountType");
            builder.Property(a => a.CreatedAt).HasColumnName("CreatedAt");
        }
    }
}
