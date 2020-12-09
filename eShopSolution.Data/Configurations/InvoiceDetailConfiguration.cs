using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class InvoiceDetailConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetails");
            builder.HasKey(t => new { t.InvoiceId, t.ProductId });
            builder.HasOne(t => t.Invoice).WithMany(t => t.InvoiceDetails).HasForeignKey(t => t.InvoiceId);
            builder.HasOne(t => t.Product).WithMany(t => t.InvoiceDetails).HasForeignKey(t => t.InvoiceId);
        }
    }
}
