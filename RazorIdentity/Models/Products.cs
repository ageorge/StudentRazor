using System;
using System.Collections.Generic;

namespace RazorIdentity.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        public int ProductColorId { get; set; }

        public Categories Category { get; set; }
        public ProductColors ProductColor { get; set; }
    }
}
