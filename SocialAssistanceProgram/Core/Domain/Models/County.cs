namespace SocialAssistanceProgram.Core.Domain.Models;

public class County
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    private County() { }

    public County(string name)
    {
        Name = name;
    }
}
