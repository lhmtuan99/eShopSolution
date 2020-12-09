using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int ComboId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
