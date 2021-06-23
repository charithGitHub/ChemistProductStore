using System;

namespace ChemistProductAPI.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; }

        public Double Price { get; set; }

        public string Type { get; set; }

        public bool Active { get; set; }
    }
}
