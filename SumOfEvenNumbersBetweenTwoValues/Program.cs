namespace SumOfEvenNumbersBetweenTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Sum += i;
                }
            }Console.WriteLine("The sum of even numbers between {0} and {1} is: {2}", firstNumber, secondNumber, Sum);
        }
    }
}
