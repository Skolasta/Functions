namespace FindTheFinalAngleOfATriangle
{
    internal class Program
    {
        static double Triangle(double angle1, double angle2)
        {
            return 180 - (angle1 + angle2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first angle of the triangle:");
            double angle1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second angle of the triangle:");
            double angle2 = Convert.ToDouble(Console.ReadLine());
            if (angle1 + angle2 >= 180)
            {
                Console.WriteLine("The sum of the angles cannot be greater than or equal to 180 degrees.");
            }
            else
            {
                Console.WriteLine("The third angle of the triangle is: " + Triangle(angle1, angle2));
            }
        }
    }
}
