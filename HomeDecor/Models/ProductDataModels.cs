using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Models
{
    public class ProductDataModels
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Pic_Path { get; set; }
        public string Detail { get; set; }
        public string Category { get; set; }
        public decimal ProductScore { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Discount_Percentage { get; set; }
        public DateTime DiscountStart { get; set; }
        public DateTime DiscountEnd { get; set; }
        public string Unit { get; set; }
        public string Amount { get; set; }
    }

    public class GetProduct<T>
    {
        public T Data { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}
