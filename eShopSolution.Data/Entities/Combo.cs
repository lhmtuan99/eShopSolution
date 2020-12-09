using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Combo
    {
        public int Id { get; set; }
        public string Combo_name { get; set; }
        public string ProductLis { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal TotalMoney { get; set; }
        public int Discount { get; set; }
        public decimal DiscountMoney { get; set; }

    }
}
