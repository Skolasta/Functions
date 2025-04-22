namespace MaxChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            input = input.ToLower();
            int currentCount = 1;
            int maxCount = 1;
            char maxChar = input[0];
            for (int i = 1; i < input.Length - 1; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentCount++;
                }
                    if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxChar = input[i];
                }
                else
                {
                    currentCount = 1;
                }
            }
            Console.WriteLine("The character that appears the most is: " + maxChar);
        }
    }
}
