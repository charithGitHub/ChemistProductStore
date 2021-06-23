using System;
using ChemistProductStore.Core.Model;

namespace ChemistProductStore.Domain.Events
{
    public class ProductCreated : BaseDomainEvent<Product, Guid>
    {
        private ProductCreated() { }

        public ProductCreated(Product product) : base(product)
        {
            Name = product.Name;
            Price = product.Price;
            Type = product.Type;
            Active = product.Active;
        }

        public string Name { get; set; }

        public Double Price { get; set; }

        public string Type { get; set; }

        public bool Active { get; set; }
    }
}
