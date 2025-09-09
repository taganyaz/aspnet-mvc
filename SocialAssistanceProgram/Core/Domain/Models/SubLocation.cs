namespace SocialAssistanceProgram.Core.Domain.Models;

public class SubLocation
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int LocationId { get; private set; }
    public Location Location { get; private set; } = null!;
    private SubLocation() { } // For EF Core
    public SubLocation(string name, int locationId)
    {
        Name = name;
        LocationId = locationId;
    }
}
