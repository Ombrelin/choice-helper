namespace ChoiceHelper.Core.Domain.Entities;

public class Choice
{
    private string name;

    public string Name
    {
        get => name;
        set => name = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Choice name can't be empty");
    }

    public List<Possibility> Possibilities { get; set; }

    public List<Possibility> RankedPossibilities => Possibilities
        .OrderByDescending(possibility => possibility.Score)
        .ToList();

    public Choice(string name)
    {
        Name = name;
        Possibilities = new List<Possibility>();
    }
}