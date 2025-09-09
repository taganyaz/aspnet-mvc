using AutoMapper;
using Inventory.Core.Application.DTOs;
using Inventory.ViewModels;

namespace Inventory.Mappings;

public class WebMappingProfile: Profile
{
    public WebMappingProfile()
    {
        CreateMap<ProductDto, CreateProductViewModel>().ReverseMap();
        CreateMap<ProductDto, EditProductViewModel>().ReverseMap();
    }
}
