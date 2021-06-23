using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemistProductAPI.Model
{
    public class ProductDetails
    {
        public ProductDetails(Guid id, string name, Double price, string type, bool active)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            Active = active;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public Double Price { get; set; }

        public string Type { get; set; }

        public bool Active { get; set; }
    }
}
