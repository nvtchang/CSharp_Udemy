var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());
Console.WriteLine("Area is " + rectangle1.CaculateArea());
rectangle1.Width = -10;

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());
Console.WriteLine("Area is " + rectangle2.CaculateArea());


class Rectangle
{
    public readonly int Width;
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));

    }

    private int GetLengthOrDefault(int length, string name)
    {
        int defaultValueIfNotPositive = 1;

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

    public int CalculateCircumference() => 2 * Width + 2 * Height;
    

    public int CaculateArea() => Width * Height;
    
}
