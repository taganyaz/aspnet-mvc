namespace SocialAssistanceProgram.Core.Domain.Models;

public class Gender
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    private Gender() { }
    public Gender(string name)
    {
        Name = name;
    }
}
