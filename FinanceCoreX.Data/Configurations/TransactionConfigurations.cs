using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceCoreX.Core.Entities;

namespace FinanceCoreX.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions"); // Tablo adı
            builder.HasKey(t => t.TransactionId); // Primary key belirleme

            builder.Property(t => t.TransactionId).HasColumnName("TransactionId"); // Sütun adı ve özellikleri
            builder.Property(t => t.SenderAccountId).HasColumnName("SenderAccountId");
            builder.Property(t => t.ReceiverAccountId).HasColumnName("ReceiverAccountId");
            builder.Property(t => t.Amount).HasColumnName("Amount");
            builder.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            builder.Property(t => t.Description).HasColumnName("Description");
            builder.Property(t => t.TransactionType).HasColumnName("TransactionType");
        }
    }
}
