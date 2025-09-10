using SocialAssistanceProgram.Core.Domain.Interfaces;
using SocialAssistanceProgram.Core.Domain.Models;
using SocialAssistanceProgram.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SocialAssistanceProgram.Infrastructure.Repositories;

public class ApplicantRepository : IApplicantRepository
{
    private readonly ApplicationDbContext _context;
    public ApplicantRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Applicant applicant)
    {
        await _context.Applicant.AddAsync(applicant);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var applicant = await _context.Applicant.FindAsync(id);
        if (applicant != null)
        {
            _context.Applicant.Remove(applicant);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Applicant>> GetAllAsync()
    {
        return await _context.Applicant.ToListAsync();
    }

    public Task<Applicant?> GetByIdAsync(int id)
    {
        return _context.Applicant
            .Include(a => a.Village)
                .ThenInclude(v => v!.SubLocation)
                    .ThenInclude(sl => sl!.Location)
                        .ThenInclude(l => l!.SubCounty)
                            .ThenInclude(sc => sc!.County)
        .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task UpdateAsync(Applicant applicant)
    {
        _context.Entry(applicant).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
