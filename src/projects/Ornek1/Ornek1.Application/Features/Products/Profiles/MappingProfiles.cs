using AutoMapper;
using Core.Persistence.Paging;
using Ornek1.Domain.Entities;
using Ornek1.Shared.Dtos.ProductImages.GetList;
using Ornek1.Shared.Dtos.Products.Create;
using Ornek1.Shared.Dtos.Products.GetList;
using Ornek1.Shared.Models.Products.GetList;

namespace Ornek1.Application.Features.Products.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreatedProductDto>().ReverseMap();
            CreateMap<IPaginate<Product>, ProductListModel>().ReverseMap();
            CreateMap<ProductImage, GetListProductImageDto>();
            CreateMap<Product, GetListProductDto>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.ProductImages, opt => opt.MapFrom(x => x.ProductImages))
                .ReverseMap();
        }
    }
}
