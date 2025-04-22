namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            while (isRunning)
            {
                if (int.Parse(input) >= 1000 && int.Parse(input) <= 9999)
                {
                    isRunning = false;
                    int firstTwo = int.Parse(input.Substring(0, 2));
                    int lastTwo = int.Parse(input.Substring(2, 2));
                    int sum = firstTwo + lastTwo;
                    if (sum * sum == int.Parse(input))
                    {
                        Console.WriteLine("The number is a Kaprekar number");
                    }
                    else
                    {
                        Console.WriteLine("The number is not a Kaprekar number");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1000 and 9999");
                    input = Console.ReadLine();
                    isRunning = true;
                }
            }
        }
    }
}
