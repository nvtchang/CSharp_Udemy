var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(2, 3);

Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());
Console.WriteLine("Area is " + rectangle1.CaculateArea());

Console.WriteLine(Rectangle.Count);


Console.WriteLine("Width" + rectangle2.GetHeight());
Console.WriteLine("Height is " + rectangle2.GetHeight());

Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());
Console.WriteLine("Area is " + rectangle2.CaculateArea());


Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multi(1, 2)}");

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multi(int a, int b) => a * b;
}

class Rectangle
{
    const int NumberOfSides = 4;
    readonly int NumberOfSidesReadonly;

    public static int Count { get; private set; }
    private static DateTime _firstUsed;


    public Rectangle(int width, int height)
    {
        _width = GetLengthOrDefault(width, nameof(_width));
        _height = GetLengthOrDefault(height, nameof(_height));
        NumberOfSidesReadonly = 4;
        ++Count;
    }

    private int _width;
    private int _height;
    public int GetHeight() => _height;
    public void SetHeight(int value)
    {
        if(value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNotPositive = 1;

        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number");
            return defaultValueIfNotPositive;
        }
        return length;
    }

    //public int CalculateCircumference()
    //{
    //    return 2*Width + 2*Height;
    //}

    //public int CaculateArea()
    //{
    //    return Width * Height;
    //}

    public int CalculateCircumference() => 2 * _width + 2 * _height;
    

    public int CaculateArea() => _width * _height;

    public string Description => $"A reactangle with width {_width}" + $"and height {_height}";

    public string LongDescription
    {
        get
        {
            var result = "";
            for (int i = 0; i < _width; i++)
            {
                result += i;
            }
            return result;
        }
    }
    public static string DescribeGenerally() => $"A plan figure";

    public const int Description1 = 4;

}
