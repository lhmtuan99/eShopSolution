using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Amount = 50,
                    Detail = "",
                    ProductName = "LG Màn Hình Cong",
                    Price = 1000000,
                    CatalogId = 1
                },
                new Product()
                {
                    Id = 2,
                    Amount = 20,
                    Detail = "",
                    ProductName = "SamSung S12",
                    Price = 2000000,
                    CatalogId = 2
                },
                new Product()
                {
                    Id = 3,
                    Amount = 50,
                    Detail = "",
                    ProductName = "SamSung Màn Hình Cong",
                    Price = 1000000,
                    CatalogId = 1
                },
                new Product()
                {
                    Id = 4,
                    Amount = 20,
                    Detail = "",
                    ProductName = "Iphone 12",
                    Price = 2000000,
                    CatalogId = 2
                }
            );
            modelBuilder.Entity<Catalog>().HasData(
               new Catalog() 
               { 
                   Id = 1,
                   CatalogName = "Tivi" 
               },
               new Catalog() 
               { 
                   Id = 2,
                   CatalogName = "Điện thoại",
               }
           );
        }
    }
}
