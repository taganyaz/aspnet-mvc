using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Applicant> Applicant { get; set; } = default!;
        public DbSet<SocialProgram> SocialPrograms { get; set; } = default!;
        public DbSet<Officer> Officers { get; set; } = default!;
        public DbSet<OfficerDesignation> OfficerDesignations { get; set; } = default!;
        public DbSet<Gender> Genders { get; set; } = default!;
        public DbSet<MaritalStatus> MaritalStatuses { get; set; } = default!;

        public DbSet<Village> Villages { get; set; } = default!;
        public DbSet<SubLocation> SubLocations { get; set; } = default!;
        public DbSet<Location> Locations { get; set; } = default!;
        public DbSet<SubCounty> SubCounties { get; set; } = default!;
        public DbSet<County> Counties { get; set; } = default!;

    }
}
