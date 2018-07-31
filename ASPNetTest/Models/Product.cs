using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetTest.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Store { get; set; }
        public decimal Price { get; set; }
    }
}
