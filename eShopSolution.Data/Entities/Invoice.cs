using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Invoice
    {
        public int Id {get; set;}
        public string InvoiceName {get; set;}
        public int CustomerId {get; set;}
        public decimal TotalMoney {get; set;}
        public string CreateDate {get; set;}
        public string CustomerAddress { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
