using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dogsRus.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}