namespace Basing
{
    internal class Program
    {
        static double Basing(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Base number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exponent number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Base number raised to the power of exponent number: " + Basing(num1, num2));
        }
    }
}
