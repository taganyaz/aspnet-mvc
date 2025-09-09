namespace SocialAssistanceProgram.Core.Domain.Models;

public class Officer
{
    public int Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string MiddleName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int OfficerDesignationId { get; private set; }
    public OfficerDesignation OfficerDesignation { get; private set; } = null!;

    public string FullName => $"{FirstName} {MiddleName} {LastName}".Replace("  ", " ").Trim();

    private Officer() { } // For EF Core
    public Officer(string firstName, string middleName, string lastName, int officerDesignationId)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        OfficerDesignationId = officerDesignationId;
    }
}
