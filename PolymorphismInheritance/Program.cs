var numbers = new List<int> { 1, 2, 5, 6 , -11, 12,-14, 18 };
var cal = new NumberSumCalculator();
var posCal = new NumberSumCalculator();
var shallAddPositiveOnly = true;

NumberSumCalculator calculator = shallAddPositiveOnly ? new NumberPositiveCalculator() : new NumberSumCalculator();

int result = calculator.Calculator(numbers);

Console.WriteLine(result);
public class NumberSumCalculator {
    public int Calculator(List<int> numbers)
    {
        int sum = 0;
        foreach(var numberItem in numbers)
        {
            if(ShallBeAdd(numberItem)) {
                sum += numberItem;
            }
        }
        return sum;
    }
    protected virtual bool ShallBeAdd(int number)
    {
        return true;
    }
}

public class NumberPositiveCalculator : NumberSumCalculator
{
    protected override bool ShallBeAdd(int number)
    {
        return number > 0;
    }
}