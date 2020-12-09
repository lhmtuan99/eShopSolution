using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data
{
    public class Catalog
    {
        public int Id { get; set; }
        public string CatalogName { get; set; }
        public List<Product> Products { get; set; }
    }
}
