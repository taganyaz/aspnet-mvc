namespace SocialAssistanceProgram.Core.Application.DTOs;

public class ApplicantDto
{
    public int Id { get; set; }
    public DateOnly ApplicationDate { get; set; }
    public string FirstName { get;  set; } = string.Empty;
    public string MiddleName { get;  set; } = string.Empty;
    public string LastName { get;  set; } = string.Empty;
    public DateOnly DateOfBirth { get;  set; }
    public int GenderId { get;  set; }
    public int MaritalStatusId { get;  set; }
    public string IdNumber { get;  set; } = string.Empty;
    public string PostalAddress { get;  set; } = string.Empty;
    public string PhysicalAddress { get;  set; } = string.Empty;
    public int SocialProgramId { get;  set; }

    public readonly List<PhoneContactDto> PhoneContacts = new();
    public int VillageId { get;  set; }
    public int OfficerId { get;  set; }
    public DateOnly SignedDate { get;  set; }
    public string FullName => $"{FirstName} {MiddleName} {LastName}".Replace("  ", " ").Trim();
}
