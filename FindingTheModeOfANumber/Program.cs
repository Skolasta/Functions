namespace FindingTheModeOfANumber
{
    internal class Program
    {
        static int Chapter (int num1, int num2)
        {
            return num1 / num2;
        }
        static double ModeNumber(double num1, double num2)
        {
            return num1 % num2; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Modu alınacak sayı");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Modu alacak sayı");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Modu alınacak sayının modunu alacak sayı ile modu: " + ModeNumber(num1, num2));
            Console.WriteLine("Modu alınacak sayının modunu alacak sayı ile bölümü: " + Chapter((int)num1, (int)num2));


        }
    }
}
