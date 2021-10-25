using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get;  set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Pic_Path { get; set; }
        public string Detail { get; set; }
    }
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
    public class ProductRating
    {
        [Key]
        public int RatingId { get; set; }
        public int ProductId { get; set; }
        public decimal ProductScore { get; set; }
    }
}
