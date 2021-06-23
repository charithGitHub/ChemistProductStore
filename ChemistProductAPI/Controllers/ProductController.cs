using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChemistProductAPI.Queries;
using ChemistProductAPI.DTOs;
using MediatR;
using ChemistProductStore.Domain.Commands;

namespace ChemistProductAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            var query = new AllProducts();
            var results = await _mediator.Send(query, cancellationToken);
            if (null == results)
                return NotFound();
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto, CancellationToken cancellationToken = default)
        {
            if (null == dto)
                return BadRequest();
            var command = new CreateProduct(Guid.NewGuid(),dto.Name,dto.Price,dto.Type,dto.Active);
            await _mediator.Publish(command, cancellationToken);

            return CreatedAtAction("GetProducts", new { id = command.ProductId }, command);
        }
    }
}
