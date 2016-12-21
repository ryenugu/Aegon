using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aegon.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? AUM { get; set; }
        public string Benchmark { get; set; }

    }

}