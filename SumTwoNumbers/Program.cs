namespace SumTwoNumbers
{
    internal class Program
    {
        static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = Sum(firstNumber, secondNumber);

            Console.WriteLine("The sum of {0} and {1} is: {2}", firstNumber, secondNumber, result);
        }
    }

}
