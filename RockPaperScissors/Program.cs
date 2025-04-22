namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> game = new List<string>();
            game.Add("Rock");
            game.Add("Paper");
            game.Add("Scissors");
            Console.WriteLine("Welcome to Rock Paper Scissors Game!");
            Console.WriteLine("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName + "! Let's start the game.");
            Console.WriteLine("Please enter the number of rounds you want to play: ");
            int rounds = int.Parse(Console.ReadLine());
            int playerScore = 0;
            int computerScore = 0;
            Random random = new Random();
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("Round " + (i + 1) + ":");
                Console.WriteLine("Please enter your choice (Rock, Paper, Scissors): ");
                string playerChoice = Console.ReadLine();
                int computerChoiceIndex = random.Next(0, game.Count);
                string computerChoice = game[computerChoiceIndex];
                Console.WriteLine("Computer chose: " + computerChoice);
                Console.WriteLine("Your choice: " + playerChoice);
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                         (playerChoice == "Paper" && computerChoice == "Rock") ||
                         (playerChoice == "Scissors" && computerChoice == "Paper"))
                {
                    Console.WriteLine("You win this round!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!");
                    computerScore++;
                }
            }
            Console.WriteLine("Game Over!");
            Console.WriteLine("Your score: " + playerScore);
            Console.WriteLine("Computer's score: " + computerScore);
            if (playerScore > computerScore)
            {
                Console.WriteLine("Congratulations " + playerName + "! You are the overall winner!");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("Computer is the overall winner!");
            }
            else
            {
                Console.WriteLine("It's a tie overall!");
            }
            {
                
            }
        }
    }
}
