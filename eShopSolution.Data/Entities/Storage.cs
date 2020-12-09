using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Storage
    {
        public int ProductId {get; set;}
        public int Amount {get; set;}
        public string ImportDate { get; set; }
        public string ExportDate { get; set; }
        public Product Product { get; set; }

    }
}
