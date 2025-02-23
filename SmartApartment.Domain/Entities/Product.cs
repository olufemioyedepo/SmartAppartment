﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartApartment.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
