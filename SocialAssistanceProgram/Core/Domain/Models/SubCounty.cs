namespace SocialAssistanceProgram.Core.Domain.Models;

public class SubCounty
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int CountyId { get; private set; }
    public County County { get; private set; } = null!;

    private SubCounty() { } // For EF Core
    public SubCounty(string name, int countyId)
    {
        Name = name;
        CountyId = countyId;
    }
}
