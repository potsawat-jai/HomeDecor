using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Models
{
    public class ProductRating
    {
            [Key]
            public int RatingId { get; set; }
            public int ProductId { get; set; }
            public decimal ProductScore { get; set; }
    }
}
