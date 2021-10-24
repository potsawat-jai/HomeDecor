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
        public string Catageory { get; set; }
        public string Pic_Path { get; set; }
    }
}
