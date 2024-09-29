var ex = new Exercise();
var strings = new List<string> { "bobcat", "wolverine", "grizzly" };
var result = ex.ProcessAll(strings);
Console.WriteLine(result);
public class Exercise
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }
}

public class StringsProcessor
{
    public List<string> Process(List<string> strings)
    {
        var result = new List<string>();
        var value = "";
        foreach (var item in strings)
        {
            if(modifyType == "trim")
            {
                value = item.Substring(0, item.Length / 2);
            }
            else
            {
                value = item.ToUpper();
            }
            result.Add(value);
        }    
        return result;
    }

    protected virtual string? modifyType => null;
}

public class StringsTrimmingProcessor : StringsProcessor
{
    protected override string? modifyType => "trim";
}

public class StringsUppercaseProcessor : StringsProcessor
{
    protected override string? modifyType => "upper";
}