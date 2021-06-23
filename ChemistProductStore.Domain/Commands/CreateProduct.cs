using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ChemistProductStore.Core;

namespace ChemistProductStore.Domain.Commands
{
    public class CreateProduct : INotification
    {
        public CreateProduct(Guid productId, string name, Double price, string type, bool active)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Type = type;
            Active = active;
        }
        public Guid ProductId { get; }
        public string Name { get;  }

        public Double Price { get; }

        public string Type { get; }

        public bool Active { get; }
    }

    public class CreateProductHandler : INotificationHandler<CreateProduct>
    {
        private readonly IEventsService<Product, Guid> _productEventsService;
        public CreateProductHandler(IEventsService<Product, Guid> productEventService)
        {
            _productEventsService = productEventService;
        }
        public async Task Handle(CreateProduct command, CancellationToken cancellationToken)
        {
            var product = new Product(command.ProductId, command.Name, command.Price,command.Type, command.Active);

            await _productEventsService.PersistAsync(product);
        }
    }
}
