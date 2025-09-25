using AutoMapper;
using SocialAssistanceProgram.Core.Application.DTOs;
using SocialAssistanceProgram.Core.Application.Interfaces;
using SocialAssistanceProgram.Core.Domain.Interfaces;
using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Core.Application.Services;

public class ApplicantService : IApplicantService
{
    private readonly IApplicantRepository _applicantRepository;
    private readonly IMapper _mapper;

    public ApplicantService(IApplicantRepository applicantRepository, IMapper mapper)
    {
        _applicantRepository = applicantRepository;
        _mapper = mapper;
    }
    public async Task AddApplicantAsync(ApplicantDto applicantDto)
    {
        
        var applicant = new Applicant(
            applicantDto.ApplicationDate,
            applicantDto.FirstName,
            applicantDto.MiddleName,
            applicantDto.LastName,
            applicantDto.DateOfBirth,
            applicantDto.GenderId,
            applicantDto.MaritalStatusId,
            applicantDto.IdNumber,
            applicantDto.PostalAddress,
            applicantDto.PhysicalAddress,
            applicantDto.SocialProgramId,
            applicantDto.VillageId,
            applicantDto.OfficerId,
            applicantDto.SignedDate
            );

        foreach (var phoneContactDto in applicantDto.PhoneContacts)
        {
            var phoneContact = new PhoneContact(
                applicant,
                phoneContactDto.PhoneNumber
                );
            applicant.PhoneContacts.Add(phoneContact);
        }

        await _applicantRepository.AddAsync(applicant);
    }

    public async Task DeleteApplicantAsync(int id)
    {
        var applicant = _applicantRepository.GetByIdAsync(id);
        if (applicant != null)
        {
            await _applicantRepository.DeleteAsync(id);
        }
    }

    public async Task<IEnumerable<ApplicantDto>> GetAllApplicantsAsync()
    {
        var applicants = await _applicantRepository.GetAllAsync();

        return _mapper.Map<IEnumerable<ApplicantDto>>(applicants);
    }

    public async Task<ApplicantDto> GetApplicantByIdAsync(int id)
    {
        var applicant = await _applicantRepository.GetByIdAsync(id);
        return _mapper.Map<ApplicantDto>(applicant);
    }

    public async Task UpdateApplicantAsync(ApplicantDto applicantDto)
    {
        var applicant = await _applicantRepository.GetByIdAsync(applicantDto.Id);
        if (applicant != null)
        {
            applicant.Update(
                applicantDto.ApplicationDate,
                applicantDto.FirstName,
                applicantDto.MiddleName,
                applicantDto.LastName,
                applicantDto.DateOfBirth,
                applicantDto.GenderId,
                applicantDto.MaritalStatusId,
                applicantDto.IdNumber,
                applicantDto.PostalAddress,
                applicantDto.PhysicalAddress,
                applicantDto.SocialProgramId,
                applicantDto.VillageId,
                applicantDto.OfficerId,
                applicantDto.SignedDate
                );

            await _applicantRepository.UpdateAsync(applicant);

        }

    }
}
