using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class StorageConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.ToTable("Storages");
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.Amount);
            builder.Property(x => x.ImportDate);
            builder.Property(x => x.ExportDate);
        }
    }
}
