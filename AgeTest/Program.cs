namespace AgeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            AgeTest(age);
        }
        static void AgeTest(int age)
        {
            if (age < 11)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 11 && age <= 17)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 18 && age <= 64)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }

        }
    }
}