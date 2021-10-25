using HomeDecor.DbModels;
using HomeDecor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Controllers
{
    [Route("api/{Controller}")]
    [ApiController]
    public class HomeDecorController : Controller
    {
        private ApiContext _context;

        public HomeDecorController(ApiContext context)
        {
            _context = context;
        }


        [Route("/{id?}")]
        [HttpGet]
        public IActionResult Index(int ProductId = 0)
        {

            var Joinproduct = (from p in _context.Products
                               join e in _context.ProductRatings on p.ProductId equals e.ProductId
                               join q in _context.ProductPricings on p.ProductId equals q.ProductId
                               select new ProductDataModels
                               {
                                   ProductId = p.ProductId,
                                   ProductName = p.ProductName,
                                   Pic_Path = p.Pic_Path,
                                   Detail = p.Detail,
                                   Category = p.Category,
                                   ProductScore = e.ProductScore,
                                   ProductPrice = q.ProductPrice,
                                   Amount = q.Amount,
                                   Unit = q.Unit,
                                   Discount_Percentage = q.Discount_Percentage,
                                   DiscountStart = q.DiscountStart,
                                   DiscountEnd = q.DiscountEnd,

                               });

            if (ProductId != 0)
            {
                Joinproduct = Joinproduct.Where(x => x.ProductId == ProductId);
            }

            


            return View(Joinproduct.ToList());
        }


        [HttpGet]
        public IActionResult GetProduct(int ProductId = 0)
        {
            var Joinproduct = (from p in _context.Products
                               join e in _context.ProductRatings on p.ProductId equals e.ProductId
                               join q in _context.ProductPricings on p.ProductId equals q.ProductId
                               select new ProductDataModels
                               {
                                   ProductId = p.ProductId,
                                   ProductName = p.ProductName,
                                   Pic_Path = p.Pic_Path,
                                   Detail = p.Detail,
                                   Category = p.Category,
                                   ProductScore = e.ProductScore,
                                   ProductPrice = q.ProductPrice,
                                   Amount = q.Amount,
                                   Unit = q.Unit,
                                   Discount_Percentage = q.Discount_Percentage,
                                   DiscountStart = q.DiscountStart,
                                   DiscountEnd = q.DiscountEnd,

                               });

            if (ProductId != 0)
            {
                Joinproduct = Joinproduct.Where(x => x.ProductId == ProductId);
            }


            return Json(Joinproduct.ToList());
        }

        //[Route("~/api/GetProductRating/{id?}")]
        //[HttpGet]
        //public GetProduct<DataTable> GetProductRating()
        //{
        //    GetProduct<DataTable> replyCls = new GetProduct<DataTable>();
        //    try
        //    {
        //        var Joinproduct = (from p in _context.Products
        //                           join e in _context.ProductRatings on p.ProductId equals e.ProductId
        //                           join q in _context.ProductPricings on p.ProductId equals q.ProductId
        //                           select new ProductDataModels
        //                           {
        //                               ProductId = p.ProductId,
        //                               ProductName = p.ProductName,
        //                               Pic_Path = p.Pic_Path,
        //                               Catageory = p.Catageory,
        //                               ProductScore = e.ProductScore,
        //                               ProductPrice = q.ProductPrice,
        //                               Amount = q.Amount,
        //                               Unit = q.Unit,
        //                               Discount_Percentage = q.Discount_Percentage,
        //                               DiscountStart = q.DiscountStart,
        //                               DiscountEnd = q.DiscountEnd,

        //                           });
        //        replyCls.Data = (DataTable)Joinproduct;
        //    } catch (Exception ex)
        //    {
        //        replyCls.ResultCode = "P";
        //        replyCls.ResultMessage = ex.Message;

        //    }

        //    return replyCls;
        //}
        //[HttpPost]
        //public IActionResult Add(Product product)
        //{
        //    var newID = _context.Products.Select(x => x.ProductId).Max() + 1;
        //    product.ProductId = newID
        //}


        public IActionResult ProductDetail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
