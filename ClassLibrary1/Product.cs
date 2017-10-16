using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    class Product
    {
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public double ProductPrice { set; get; }
        public double ProductSellPrice { set; get; }
        public double quantity { set; get; }
    }
}
