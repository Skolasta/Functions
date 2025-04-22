namespace CircumferenceOfTheCircle
{
    internal class Program
    {
        static double Circle(double radius)
        {
            const double PI = 3.14;
            return 2 * PI * radius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circle Circumference's: " + (Circle(radius)));
        }
    }
}
