using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ornek1.Application.Services.Repositories;
using Ornek1.Domain.Entities;
using Ornek1.Shared.Models.Products.GetList;


namespace Ornek1.Application.Features.Products.Queries.GetList
{
    public class GetListProductQuery : IRequest<ProductListModel>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, ProductListModel>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetListProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ProductListModel> Handle(GetListProductQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Product> products = await _productRepository.GetListAsync(
                    include: p => p.Include((c => c.Category)).Include(pi => pi.ProductImages),
                    index: request.PageRequest.Page, size: request.PageRequest.PageSize,
                    cancellationToken: cancellationToken);

                ProductListModel productListModel = _mapper.Map<ProductListModel>(products);
                return productListModel;

            }
        }
    }
}
