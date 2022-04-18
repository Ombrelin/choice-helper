namespace ChoiceHelper.Core.Domain.Entities;

public class Possibility
{
    private string name;

    public string Name
    {
        get => name;
        set => name = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Choice name can't be empty");
    }

    public List<PossibilityLabel> Labels;

    public int Score => Labels.Select(label => label.Score).Sum();

    public Possibility(string name)
    {
        Name = name;
        Labels = new List<PossibilityLabel>();
    }
}