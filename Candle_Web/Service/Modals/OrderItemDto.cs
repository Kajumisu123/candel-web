﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Modals
{
    public class OrderItemDto
    {
        public int CandleId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
