using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Core.Domain.Interfaces;

public interface IApplicantRepository
{
    Task<IEnumerable<Applicant>> GetAllAsync();
    Task<Applicant?> GetByIdAsync(int id);
    Task AddAsync(Applicant applicant);
    Task UpdateAsync(Applicant applicant);
    Task DeleteAsync(int id);
}
