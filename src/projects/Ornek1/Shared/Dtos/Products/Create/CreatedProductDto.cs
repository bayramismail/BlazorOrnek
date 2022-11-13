﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Shared.Dtos.Products.Create
{
    public class CreatedProductDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }     
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
