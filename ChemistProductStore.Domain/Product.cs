using System;
using ChemistProductStore.Core.Model;
using ChemistProductStore.Domain.Events;

namespace ChemistProductStore.Domain
{
    public class Product : BaseAggregateRoot<Product, Guid>
    {
        private Product() { }

        public Product(Guid id, string name, Double price, string type, bool active): base(id)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.Active = active;

            this.AddEvent(new ProductCreated(this));
        }

        public string Name { get; set; }

        public Double Price { get; set; }

        public string Type { get; set; }

        public bool Active { get; set; }

        protected override void Apply(IDomainEvent<Guid> @event)
        {
            switch (@event)
            {
                case ProductCreated c:
                    this.Id = c.AggregateId;
                    this.Name = c.Name;
                    this.Price = c.Price;
                    this.Type = c.Type;
                    this.Active = c.Active;
                    break;                
            }
        }

        public static Product Create(string name, Double price, string type, bool active)
        {
            return new Product(Guid.NewGuid(), name, price, type, active);
        }
    }
}
