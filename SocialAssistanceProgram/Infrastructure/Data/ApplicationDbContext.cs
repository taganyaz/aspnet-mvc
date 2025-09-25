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
        public DbSet<PhoneContact> PhoneContacts { get; set; } = default!;
        public DbSet<ApplicantSocialProgram> ApplicantSocialPrograms { get; set; } = default!;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship between Applicant and SocialProgram
            // Use composite primary key of ApplicantId and SocialProgramId
            modelBuilder.Entity<ApplicantSocialProgram>()
                .HasKey(asp => new { asp.ApplicantId, asp.SocialProgramId });

            modelBuilder.Entity<ApplicantSocialProgram>()
                .HasOne(asp => asp.Applicant)
                .WithMany(a => a.ApplicantSocialPrograms)
                .HasForeignKey(asp => asp.ApplicantId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<ApplicantSocialProgram>()
            //    .HasOne(asp => asp.SocialProgram)
            //    .WithMany(sp => sp.ApplicantSocialPrograms)
            //    .HasForeignKey(asp => asp.SocialProgramId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
