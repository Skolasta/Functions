namespace VolumeOfTheCylinder
{
    internal class Program
    {
        static double Cylinder (double radius, double height)
        {
            const double PI = 3.14;
            return PI * radius * radius * height;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the cylinder:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of the cylinder:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cylinder Volume's: " + (Cylinder(radius, height)));
            
        }
    }
}
