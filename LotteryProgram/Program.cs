
namespace LotteryProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people will participate in the lottery? ");
            int ticketCount = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < ticketCount; i++)
            {
                Console.WriteLine("Write the names and surnames of the people who will participate in the lottery");
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine("The names of the people who will participate in the lottery are: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            //Multiple winner
            Console.WriteLine("How many winners do you want?");
            int winnerCount = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < winnerCount; i++)
            {
                int winner = random.Next(ticketCount - 1);
                Console.WriteLine("The winner of the lottery is: " + names[winner]);
            }
            /*Console.WriteLine("The winner of the lottery is: ");
            // Randomly select a winner from the list of names (Just one)
            Random random = new Random();
            int winnerIndex = random.Next(0, names.Count);
            Console.WriteLine(names[winnerIndex]);*/
        }
    }
}
