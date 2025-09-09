using AutoMapper;
using Inventory.Core.Application.DTOs;
using Inventory.Core.Domain.Models;

namespace Inventory.Core.Application.Mappings;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}
