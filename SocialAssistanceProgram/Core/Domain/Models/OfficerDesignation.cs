namespace SocialAssistanceProgram.Core.Domain.Models;

public class OfficerDesignation
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    private OfficerDesignation() { } // For EF Core
    public OfficerDesignation(string name)
    {
        Name = name;
    }
}
