namespace DiceRollGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number  = GenerateNumber.GetRandomNumber();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
            string input = Console.ReadLine();
            bool isNumber  = Validation.Number(input);

            if(!isNumber)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Enter number:");
                input =  Console.ReadLine();
                isNumber = Validation.Number(input);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    int x = Int32.Parse(input);

                    NumberComparison.Check(number, x);
                    Console.WriteLine("Enter number:");
                    input = Console.ReadLine();
                }
                Console.WriteLine("You lose");

            }

        }
    }
}
