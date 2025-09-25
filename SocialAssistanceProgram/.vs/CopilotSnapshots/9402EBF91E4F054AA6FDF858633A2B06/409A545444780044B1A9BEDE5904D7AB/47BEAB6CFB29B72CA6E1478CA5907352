namespace SocialAssistanceProgram.Core.Domain.Models;

public class PhoneContact
{
    public int Id { get; private set; }
    public int ApplicantId { get; private set; }
    public Applicant Applicant { get; private set; } = null!;
    public string PhoneNumber { get; private set; } = string.Empty;

    private PhoneContact() { } // For EF Core
    public PhoneContact(Applicant applicant, string phoneNumber)
    {
        Applicant = applicant;
        PhoneNumber = phoneNumber;
    }
}
