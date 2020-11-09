﻿using System.Collections.Generic;

namespace Inventory.Model.Models
{
    public class SoftwareCompany
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}