﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double? Discount { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
