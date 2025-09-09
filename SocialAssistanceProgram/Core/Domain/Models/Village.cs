namespace SocialAssistanceProgram.Core.Domain.Models;

public class Village
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int SubLocationId { get; private set; }
    public SubLocation SubLocation { get; private set; } = null!;

    private Village() { } // For EF Core
    public Village(string name, int subLocationId)
    {
        Name = name;
        SubLocationId = subLocationId;
    }
}
