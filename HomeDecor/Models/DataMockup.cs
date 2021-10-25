using HomeDecor.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Models
{
    public class DataMockup
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                // Look for any board games.
                if (context.Products.Any())
                {
                    return;   // Data was already seeded
                }

                var DefaultDatetime = DateTime.MinValue;
                var Datetimenow = DateTime.Now;

                context.Products.AddRange(
                    new Product
                    {
                        ProductId = 1,
                        ProductName = "Minimalist floor shelf",
                        Pic_Path = "minimal_floor_shelf.jpg",
                        Detail = "Minimal 5 floor shelf",
                        Category = "SHELF"
                    },
                    new Product
                    {
                        ProductId = 2,
                        ProductName = "LED Desk Lamp",
                        Pic_Path = "LED_Desk_Lamp.jpg",
                        Detail = "Desk lamp with led can turn 360 deegrees",
                        Category = "LAMP"
                    },
                    new Product
                    {
                        ProductId = 3,
                        ProductName = "Glass shade lamp",
                        Pic_Path = "glass_shade_lamp.jpg",
                        Detail = "Glass round lamp",
                        Category = "LAMP"
                    },
                    new Product
                    {
                        ProductId = 4,
                        ProductName = "Mango wood dining table",
                        Pic_Path = "Mango_wood_table.jpg",
                        Detail = "Wood table mango color",
                        Category = "TABLE"
                    },
                    new Product
                    {
                        ProductId = 5,
                        ProductName = "Nordic desk lamp",
                        Pic_Path = "Nordic_lamp.jpg",
                        Detail = "Nordic lamp led",
                        Category = "LAMP"
                    },
                    new Product
                    {
                        ProductId = 6,
                        ProductName = "Fan Dining Chair",
                        Pic_Path = "Fan_Dining_Chair.jpg",
                        Detail = "Dining chair",
                        Category = "CHAIR"
                    },
                    new Product
                    {
                        ProductId = 7,
                        ProductName = "Oak Wood Round ArmChair",
                        Pic_Path = "Oak_Wood_Round_ArmChair.jpg",
                        Detail = "Round ArmChair",
                        Category = "CHAIR"
                    },
                    new Product
                    {
                        ProductId = 8,
                        ProductName = "Alfred Side Table",
                        Pic_Path = "Alfred_Side_Table.jpg",
                        Detail = "Side table",
                        Category = "TABLE"
                    });

                context.ProductRatings.AddRange(
                    new ProductRating
                    {
                        RatingId = 1,
                        ProductId = 1,
                        ProductScore = 5,
                    },
                    new ProductRating
                    {
                        RatingId = 2,
                        ProductId = 3,
                        ProductScore = 5,
                    },
                    new ProductRating
                    {
                        RatingId = 3,
                        ProductId = 4,
                        ProductScore = 4,
                    },
                    new ProductRating
                    {
                        RatingId = 4,
                        ProductId = 5,
                        ProductScore = 5,
                    },
                    new ProductRating
                    {
                        RatingId = 5,
                        ProductId = 2,
                        ProductScore = 0,
                    },
                    new ProductRating
                    {
                        RatingId = 6,
                        ProductId = 6,
                        ProductScore = 0,
                    },
                    new ProductRating
                    {
                        RatingId = 7,
                        ProductId = 7,
                        ProductScore = 0,
                    },
                    new ProductRating
                    {
                        RatingId = 8,
                        ProductId = 8,
                        ProductScore = 0,
                    });

                context.ProductPricings.AddRange(
                    new ProductPricing
                    {
                        ProductPricingId = 1,
                        ProductId = 1,
                        ProductPrice = 20,
                        Amount = "5",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 2,
                        ProductId = 2,
                        ProductPrice = 60,
                        Amount = "1",
                        Unit = "",
                        Discount_Percentage = 20,
                        DiscountStart = Datetimenow,
                        DiscountEnd = Datetimenow.AddDays(5),
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 3,
                        ProductId = 3,
                        ProductPrice = 55,
                        Amount = "0",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 4,
                        ProductId = 4,
                        ProductPrice = 150,
                        Amount = "1",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 5,
                        ProductId = 5,
                        ProductPrice = 55,
                        Amount = "0",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 6,
                        ProductId = 6,
                        ProductPrice = 55,
                        Amount = "10",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 7,
                        ProductId = 7,
                        ProductPrice = 55,
                        Amount = "8",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    },
                    new ProductPricing
                    {
                        ProductPricingId = 8,
                        ProductId = 8,
                        ProductPrice = 55,
                        Amount = "1",
                        Unit = "",
                        Discount_Percentage = 0,
                        DiscountStart = DefaultDatetime,
                        DiscountEnd = DefaultDatetime,
                    });

                context.SaveChanges();

            }
        }
    }
}