using AutoMapper;
using SocialAssistanceProgram.Core.Application.DTOs;
using SocialAssistanceProgram.ViewModels;

namespace SocialAssistanceProgram.Mappings;

public class WebMappingProfile: Profile
{
    public WebMappingProfile()
    {
        CreateMap<CreateApplicantViewModel, ApplicantDto>()
            .ForMember(dest => dest.PhoneContacts, opt => opt.MapFrom(src => src.PhoneContacts ?? new List<PhoneContactDto>())).ReverseMap();
        CreateMap<EditApplicantViewModel, ApplicantDto>()
            .ForMember(dest => dest.PhoneContacts, opt => opt.MapFrom(src => src.PhoneContacts ?? new List<PhoneContactDto>())).ReverseMap();
    }
}
