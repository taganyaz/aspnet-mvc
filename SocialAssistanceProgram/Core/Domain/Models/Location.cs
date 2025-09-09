namespace SocialAssistanceProgram.Core.Domain.Models;

public class Location
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int SubCountyId { get; private set; }
    public SubCounty SubCounty { get; private set; } = null!;

    private Location() { } // For EF Core
    public Location(string name, int subCountyId)
    {
        Name = name;
        SubCountyId = subCountyId;
    }
}
