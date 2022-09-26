﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
