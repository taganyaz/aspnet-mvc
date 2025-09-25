using SocialAssistanceProgram.Core.Application.DTOs;

namespace SocialAssistanceProgram.Core.Application.Interfaces;

public interface IApplicantService
{
    Task<IEnumerable<ApplicantDto>> GetAllApplicantsAsync();
    Task<ApplicantDto> GetApplicantByIdAsync(int id);
    Task AddApplicantAsync(ApplicantDto applicantDto);
    Task UpdateApplicantAsync(ApplicantDto applicantDto);
    Task DeleteApplicantAsync(int id);
}
