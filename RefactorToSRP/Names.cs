public class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _nameValidator = new NamesValidator();
    public void AddNames(List<string> stringFromFile)
    {
        foreach (var name in stringFromFile)
        {
            AddName(name);
        }
    }
    public void AddName(string name)
    {
        if (_nameValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
}