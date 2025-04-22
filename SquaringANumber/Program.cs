namespace SquaringANumber
{
    internal class Program
    {
        static int Square(int number)
        {
            return number * number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to square the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of the number you entered is: " + Square(number));
        }
    }
}
