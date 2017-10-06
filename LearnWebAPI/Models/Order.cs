using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnWebAPI.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public int SourceOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string SKU { get; set; }
        public string SKU_Desc { get; set; }
        public int Quantity { get; set; } 
        public string Image { get; set; }
    }
}