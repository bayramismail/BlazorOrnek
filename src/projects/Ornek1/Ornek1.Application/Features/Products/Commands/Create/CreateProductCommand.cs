using AutoMapper;
using MediatR;
using Ornek1.Application.Services.Repositories;
using Ornek1.Domain.Entities;
using Ornek1.Shared.Dtos.Products.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Application.Features.Products.Commands.Create
{
    public class CreateProductCommand : IRequest<CreatedProductDto>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreatedProductDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<CreatedProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var productMapper = _mapper.Map<Product>(request);
                var createdProduct = await _productRepository.AddAsync(productMapper);
                var createdProductDtoMapper = _mapper.Map<CreatedProductDto>(createdProduct);
                return createdProductDtoMapper;
            }
        }
    }
}
