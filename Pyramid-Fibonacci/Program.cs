namespace PyramidSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many layers do you want the pyramid to have?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The pyramid is:");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine();
            }

        }
    }
}
