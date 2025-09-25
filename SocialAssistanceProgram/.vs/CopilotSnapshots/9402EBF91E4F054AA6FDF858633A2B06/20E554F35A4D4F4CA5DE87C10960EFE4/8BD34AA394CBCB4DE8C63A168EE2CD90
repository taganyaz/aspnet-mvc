using AutoMapper;
using SocialAssistanceProgram.Core.Application.DTOs;
using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Core.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Applicant, ApplicantDto>()
            .ForMember(dest => dest.CountyId, opt => opt 
                .MapFrom(src => src.Village.SubLocation.Location.SubCounty.CountyId))
            .ForMember(dest => dest.SubCountyId, opt => opt
                .MapFrom(src => src.Village.SubLocation.Location.SubCountyId))
            .ForMember(dest => dest.LocationId, opt => opt
                .MapFrom(src => src.Village.SubLocation.LocationId))
            .ForMember(dest => dest.SubLocationId, opt => opt
                .MapFrom(src => src.Village.SubLocationId))
            .ForMember(dest => dest.VillageId, opt => opt
                .MapFrom(src => src.VillageId));
        CreateMap<PhoneContact, PhoneContactDto>().ReverseMap();
    }
}
