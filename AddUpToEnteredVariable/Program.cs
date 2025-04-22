namespace AddUpToEnteredVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long do you want it to be collected? ");
            int EnteredVariable = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= EnteredVariable; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of the numbers from 0 to {0} is: {1}", EnteredVariable, sum);
        }
    }
}
