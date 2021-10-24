using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.DbModels
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }


        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.ProductRating> ProductRatings { get; set; }
        public DbSet<Models.ProductPricing> ProductPricings { get; set; }

    }
}
