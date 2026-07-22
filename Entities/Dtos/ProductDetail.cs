using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ProductDetail:IDto
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public required string CategoryName { get; set; }
    }
}
