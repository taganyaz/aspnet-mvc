using SocialAssistanceProgram.Infrastructure.Data;
using SocialAssistanceProgram.Core.Domain.Models;

namespace SocialAssistanceProgram.Infrastructure;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        // Ensure the database is created
        context.Database.EnsureCreated();

        // Seed data for all entities in the correct order (respecting foreign key dependencies)
        SeedCounties(context);
        SeedSubCounties(context);
        SeedLocations(context);
        SeedSubLocations(context);
        SeedVillages(context);
        SeedGenders(context);
        SeedMaritalStatuses(context);
        SeedOfficerDesignations(context);
        SeedOfficers(context);
        SeedSocialPrograms(context);
        SeedApplicants(context);
    }

    private static void SeedCounties(ApplicationDbContext context)
    {
        // Check if Counties already exist
        if (context.Counties.Any())
        {
            return; // Database has been seeded
        }

        // Seed County data
        var counties = new County[]
        {
            new County("Nairobi"),
            new County("Mombasa"),
            new County("Kiambu"),
            new County("Nakuru"),
            new County("Machakos")
        };

        foreach (County county in counties)
        {
            context.Counties.Add(county);
        }

        context.SaveChanges();
    }

    private static void SeedSubCounties(ApplicationDbContext context)
    {
        // Check if SubCounties already exist
        if (context.SubCounties.Any())
        {
            return; // Database has been seeded
        }

        // Seed SubCounty data (assuming County IDs 1-5 from previous seeding)
        var subCounties = new SubCounty[]
        {
            new SubCounty("Westlands", 1),       // Nairobi
            new SubCounty("Kasarani", 1),        // Nairobi
            new SubCounty("Kisauni", 2),         // Mombasa
            new SubCounty("Thika", 3),           // Kiambu
            new SubCounty("Nakuru East", 4)      // Nakuru
        };

        foreach (SubCounty subCounty in subCounties)
        {
            context.SubCounties.Add(subCounty);
        }

        context.SaveChanges();
    }

    private static void SeedLocations(ApplicationDbContext context)
    {
        // Check if Locations already exist
        if (context.Locations.Any())
        {
            return; // Database has been seeded
        }

        // Seed Location data (assuming SubCounty IDs 1-5 from previous seeding)
        var locations = new Location[]
        {
            new Location("Parklands", 1),        // Westlands
            new Location("Mwiki", 2),            // Kasarani
            new Location("Bamburi", 3),          // Kisauni
            new Location("Thika Town", 4),       // Thika
            new Location("Section 58", 5)        // Nakuru East
        };

        foreach (Location location in locations)
        {
            context.Locations.Add(location);
        }

        context.SaveChanges();
    }

    private static void SeedSubLocations(ApplicationDbContext context)
    {
        // Check if SubLocations already exist
        if (context.SubLocations.Any())
        {
            return; // Database has been seeded
        }

        // Seed SubLocation data (assuming Location IDs 1-5 from previous seeding)
        var subLocations = new SubLocation[]
        {
            new SubLocation("Highridge", 1),     // Parklands
            new SubLocation("Kasarani Estate", 2), // Mwiki
            new SubLocation("Bamburi Mtambo", 3), // Bamburi
            new SubLocation("Hospital", 4),      // Thika Town
            new SubLocation("Flamingo", 5)       // Section 58
        };

        foreach (SubLocation subLocation in subLocations)
        {
            context.SubLocations.Add(subLocation);
        }

        context.SaveChanges();
    }

    private static void SeedVillages(ApplicationDbContext context)
    {
        // Check if Villages already exist
        if (context.Villages.Any())
        {
            return; // Database has been seeded
        }

        // Seed Village data (assuming SubLocation IDs 1-5 from previous seeding)
        var villages = new Village[]
        {
            new Village("Highridge Central", 1),  // Highridge
            new Village("Clay City", 2),          // Kasarani Estate
            new Village("Bamburi Kwa Chief", 3),  // Bamburi Mtambo
            new Village("Blue Post", 4),          // Hospital
            new Village("Flamingo Estate", 5)     // Flamingo
        };

        foreach (Village village in villages)
        {
            context.Villages.Add(village);
        }

        context.SaveChanges();
    }

    private static void SeedGenders(ApplicationDbContext context)
    {
        // Check if Genders already exist
        if (context.Genders.Any())
        {
            return; // Database has been seeded
        }

        // Seed Gender data
        context.Genders.AddRange(
            new Gender("Male"),
            new Gender("Female"),
            new Gender("Other"),
            new Gender("Prefer not to say")
        );

        context.SaveChanges();
    }

    private static void SeedMaritalStatuses(ApplicationDbContext context)
    {
        // Check if MaritalStatuses already exist
        if (context.MaritalStatuses.Any())
        {
            return; // Database has been seeded
        }

        // Seed MaritalStatus data
        context.MaritalStatuses.AddRange(
            new MaritalStatus("Single"),
            new MaritalStatus("Married"),
            new MaritalStatus("Divorced"),
            new MaritalStatus("Widowed"),
            new MaritalStatus("Separated")
        );

        context.SaveChanges();
    }

    private static void SeedOfficerDesignations(ApplicationDbContext context)
    {
        // Check if OfficerDesignations already exist
        if (context.OfficerDesignations.Any())
        {
            return; // Database has been seeded
        }

        // Seed OfficerDesignation data
        context.OfficerDesignations.AddRange(
            new OfficerDesignation("Social Worker"),
            new OfficerDesignation("Program Officer"),
            new OfficerDesignation("Case Manager"),
            new OfficerDesignation("Field Officer"),
            new OfficerDesignation("Assistant Social Worker"),
            new OfficerDesignation("Senior Social Worker"),
            new OfficerDesignation("Program Coordinator"),
            new OfficerDesignation("Community Liaison Officer"),
            new OfficerDesignation("Benefits Advisor"),
            new OfficerDesignation("Supervisor")
        );

        context.SaveChanges();
    }

    private static void SeedOfficers(ApplicationDbContext context)
    {
        // Check if Officers already exist
        if (context.Officers.Any())
        {
            return; // Database has been seeded
        }

        // Seed Officer data (assuming OfficerDesignation IDs 1-10 from previous seeding)
        context.Officers.AddRange(
            new Officer("John", "Mwangi", "Kamau", 1),      // Social Worker
            new Officer("Mary", "Wanjiku", "Ndung'u", 2),   // Program Officer
            new Officer("Peter", "Otieno", "Ochieng", 3)    // Case Manager
        );

        context.SaveChanges();
    }

    private static void SeedSocialPrograms(ApplicationDbContext context)
    {
        // Check if SocialPrograms already exist
        if (context.SocialPrograms.Any())
        {
            return; // Database has been seeded
        }

        // Seed SocialProgram data
        context.SocialPrograms.AddRange(
            new SocialProgram("Elderly Care Assistance"),
            new SocialProgram("Child Support Program"),
            new SocialProgram("Disability Support Services"),
            new SocialProgram("Emergency Food Aid"),
            new SocialProgram("Housing Support Program")
        );

        context.SaveChanges();
    }

    private static void SeedApplicants(ApplicationDbContext context)
    {
        // Check if Applicants already exist
        if (context.Applicant.Any())
        {
            return; // Database has been seeded
        }

        // Create applicant data with realistic information
        var applicant1 = new Applicant(
            new DateOnly(2024, 1, 15),      // ApplicationDate
            "Grace",                         // FirstName
            "Wanjiku",                      // MiddleName
            "Mwangi",                       // LastName
            new DateOnly(1985, 6, 12),      // DateOfBirth
            2,                              // GenderId (Female)
            2,                              // MaritalStatusId (Married)
            "29485123",                     // IdNumber
            "P.O. Box 1234, Nairobi",       // PostalAddress
            "Highridge Central Village",     // PhysicalAddress
            1,                              // SocialProgramId (Elderly Care Assistance)
            1,                              // VillageId (Highridge Central)
            1,                              // OfficerId (John Kamau)
            new DateOnly(2024, 1, 15)       // SignedDate
        );

        var applicant2 = new Applicant(
            new DateOnly(2024, 2, 3),       // ApplicationDate
            "Samuel",                        // FirstName
            "Kipchoge",                     // MiddleName
            "Kiprotich",                    // LastName
            new DateOnly(1978, 11, 25),     // DateOfBirth
            1,                              // GenderId (Male)
            4,                              // MaritalStatusId (Widowed)
            "18765432",                     // IdNumber
            "P.O. Box 5678, Mombasa",       // PostalAddress
            "Clay City Village",            // PhysicalAddress
            2,                              // SocialProgramId (Child Support Program)
            2,                              // VillageId (Clay City)
            2,                              // OfficerId (Mary Ndung'u)
            new DateOnly(2024, 2, 5)        // SignedDate
        );

        var applicant3 = new Applicant(
            new DateOnly(2024, 2, 20),      // ApplicationDate
            "Faith",                         // FirstName
            "Nyambura",                     // MiddleName
            "Kamau",                        // LastName
            new DateOnly(1992, 3, 8),       // DateOfBirth
            2,                              // GenderId (Female)
            1,                              // MaritalStatusId (Single)
            "31245678",                     // IdNumber
            "P.O. Box 9876, Kiambu",        // PostalAddress
            "Bamburi Kwa Chief Village",    // PhysicalAddress
            3,                              // SocialProgramId (Disability Support Services)
            3,                              // VillageId (Bamburi Kwa Chief)
            3,                              // OfficerId (Peter Ochieng)
            new DateOnly(2024, 2, 22)       // SignedDate
        );

        var applicant4 = new Applicant(
            new DateOnly(2024, 3, 10),      // ApplicationDate
            "David",                         // FirstName
            "Otieno",                       // MiddleName
            "Oduya",                        // LastName
            new DateOnly(1965, 9, 15),      // DateOfBirth
            1,                              // GenderId (Male)
            2,                              // MaritalStatusId (Married)
            "15987654",                     // IdNumber
            "P.O. Box 2468, Nakuru",        // PostalAddress
            "Blue Post Village",            // PhysicalAddress
            4,                              // SocialProgramId (Emergency Food Aid)
            4,                              // VillageId (Blue Post)
            1,                              // OfficerId (John Kamau)
            new DateOnly(2024, 3, 12)       // SignedDate
        );

        // Add applicants to context
        context.Applicant.AddRange(applicant1, applicant2, applicant3, applicant4);
        context.SaveChanges();

        // Add phone contacts to each applicant
        // Applicant 1 - Grace Mwangi (3 phone numbers)
        applicant1.AddPhoneContact("0721234567");
        applicant1.AddPhoneContact("0734567890");
        applicant1.AddPhoneContact("0756789012");

        // Applicant 2 - Samuel Kiprotich (2 phone numbers)
        applicant2.AddPhoneContact("0722345678");
        applicant2.AddPhoneContact("0745678901");

        // Applicant 3 - Faith Kamau (3 phone numbers)
        applicant3.AddPhoneContact("0723456789");
        applicant3.AddPhoneContact("0736789012");
        applicant3.AddPhoneContact("0757890123");

        // Applicant 4 - David Oduya (1 phone number)
        applicant4.AddPhoneContact("0724567890");

        context.SaveChanges();
    }
}

