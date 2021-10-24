using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Models
{
    public class ProductPricing
    {
        [Key]
        public int ProductPricingId { get; set; }
            public int ProductId { get; set; }
            public decimal ProductPrice { get; set; }
            public string Amount { get; set; }
            public string Unit { get; set; }
            public decimal Discount_Percentage { get; set; }
            public DateTime DiscountStart { get; set; }
            public DateTime DiscountEnd { get; set; }
    }
}
