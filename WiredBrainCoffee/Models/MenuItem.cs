using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Models
{
    public class MenuItem
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public int Id { get; set; }
        public int Calories { get; set; }
        public int Fat { get; set; }
        public int SaturatedFat { get; set; }
        public int Fiber { get; set; }
        public int Sugar { get; set; }
    }
}