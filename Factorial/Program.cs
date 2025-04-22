namespace Factorial
{
    internal class Program
    {
        static long Factorial(long num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * Factorial(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial's number");
            long num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                Console.WriteLine("Factorial of " + num + " is: " + Factorial(num));
            }   
        }
    }
}
