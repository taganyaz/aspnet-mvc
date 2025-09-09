namespace SocialAssistanceProgram.Core.Domain.Models;

public class Applicant
{
    public int Id { get; private set; }
    public DateOnly ApplicationDate { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string MiddleName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public DateOnly DateOfBirth { get; private set; }
    public int GenderId { get; private set; }
    public Gender Gender { get; private set; } = null!;
    public int MaritalStatusId { get; private set; }
    public MaritalStatus MaritalStatus { get; private set; } = null!;
    public string IdNumber { get; private set; } = string.Empty;
    public string PostalAddress { get; private set; } = string.Empty;
    public string PhysicalAddress { get; private set; } = string.Empty;
    public int SocialProgramId { get; private set; }
    public SocialProgram SocialProgram { get; private set; } = null!;

    public readonly List<PhoneContact> PhoneContacts = new();
    public IReadOnlyList<PhoneContact> GetPhoneContacts() => PhoneContacts.AsReadOnly();
    public int VillageId { get; private set; }
    public Village Village { get; private set; } = null!;
    public int OfficerId { get; private set; }
    public Officer Officer { get; private set; } = null!;
    public DateOnly SignedDate { get; private set; }

    public string FullName => $"{FirstName} {MiddleName} {LastName}".Replace("  ", " ").Trim();

    private Applicant() { } // For EF Core
    public Applicant(
        DateOnly applicationDate,
        string firstName,
        string middleName,
        string lastName,
        DateOnly dateOfBirth,
        int genderId,
        int maritalStatusId,
        string idNumber,
        string postalAddress,
        string physicalAddress,
        int socialProgramId,
        int villageId,
        int officerId,
        DateOnly signedDate
        )
    {
        ApplicationDate = applicationDate;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GenderId = genderId;
        MaritalStatusId = maritalStatusId;
        IdNumber = idNumber;
        PostalAddress = postalAddress;
        PhysicalAddress = physicalAddress;
        SocialProgramId = socialProgramId;
        VillageId = villageId;
        OfficerId = officerId;
        SignedDate = signedDate;
    }

    public void AddPhoneContact(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Phone number cannot be empty.", nameof(phoneNumber));
        PhoneContacts.Add(new PhoneContact(this, phoneNumber));
    }

    public void RemovePhoneContact(PhoneContact phoneContact)
    {
        if (phoneContact == null)
            throw new ArgumentNullException(nameof(phoneContact));
        PhoneContacts.Remove(phoneContact);
    }

    public void Update(
        DateOnly applicationDate,
        string firstName,
        string middleName,
        string lastName,
        DateOnly dateOfBirth,
        int genderId,
        int maritalStatusId,
        string idNumber,
        string postalAddress,
        string physicalAddress,
        int socialProgramId,
        int villageId,
        int officerId,
        DateOnly signedDate
        )
    {
        ApplicationDate = applicationDate;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GenderId = genderId;
        MaritalStatusId = maritalStatusId;
        IdNumber = idNumber;
        PostalAddress = postalAddress;
        PhysicalAddress = physicalAddress;
        SocialProgramId = socialProgramId;
        VillageId = villageId;
        OfficerId = officerId;
        SignedDate = signedDate;
    }
}
