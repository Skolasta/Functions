namespace FindTheLargestOfTheEnteredNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Girmek istediğiniz sayıları aralarında boşluk bırakarak yazınız.");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int largestNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }
            }Console.WriteLine("Girdiğiniz sayılardan en büyüğü: " + largestNumber);*/

            Console.WriteLine("How many entered numbers");
            int HowManyEntered = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int largestNumber = 0;
            do
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                i++;
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            } while(i < HowManyEntered);
            Console.WriteLine(i + " numbers entered. The largest number is: " + largestNumber);

        }

    }
}
