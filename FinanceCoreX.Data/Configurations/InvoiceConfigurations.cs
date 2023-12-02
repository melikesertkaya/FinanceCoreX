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
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices"); // Tablo adı
            builder.HasKey(i => i.InvoiceId); // Primary key belirleme

            builder.Property(i => i.InvoiceId).HasColumnName("InvoiceId"); // Sütun adı ve özellikleri
            builder.Property(i => i.UserId).HasColumnName("UserId");
            builder.Property(i => i.Amount).HasColumnName("Amount");
            builder.Property(i => i.InvoiceDate).HasColumnName("InvoiceDate");
            builder.Property(i => i.IsPaid).HasColumnName("IsPaid");
        }
    }
}
