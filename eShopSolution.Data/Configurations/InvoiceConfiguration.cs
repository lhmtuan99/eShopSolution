using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.InvoiceName);
            builder.Property(x => x.TotalMoney).IsRequired();
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.CustomerAddress);
        }
    }
}
