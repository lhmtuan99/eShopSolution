using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Decimal Price { get; set; }
        public int Amount { get; set; }
        public string Detail { get; set; }
        public int CatalogId { get; set; }

    }
}
