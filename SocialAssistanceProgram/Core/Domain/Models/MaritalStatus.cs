namespace SocialAssistanceProgram.Core.Domain.Models;

public class MaritalStatus
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    private MaritalStatus() { } // For EF Core
    public MaritalStatus(string name)
    {
        Name = name;
    }
}
