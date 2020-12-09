using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ComboConfiguration : IEntityTypeConfiguration<Combo>
    {
        public void Configure(EntityTypeBuilder<Combo> builder)
        {
            builder.ToTable("Comboes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Combo_name);
            builder.Property(x => x.ProductLis).IsRequired();
            builder.Property(x => x.TotalMoney).IsRequired();
            builder.Property(x => x.Discount);
            builder.Property(x => x.DiscountMoney);
        }
    }
}
