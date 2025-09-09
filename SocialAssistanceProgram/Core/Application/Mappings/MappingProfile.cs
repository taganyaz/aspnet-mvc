using AutoMapper;
using SocialAssistanceProgram.Core.Application.DTOs;
using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Core.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Applicant, ApplicantDto>().ReverseMap();
        CreateMap<PhoneContact, PhoneContactDto>().ReverseMap();
    }
}
