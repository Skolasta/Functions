namespace ResultExam
{
    internal class Program
    {
        static double ExamResult(double score1, double score2)
        {
            return (score1 + score2) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first exam result: ");
            double firstExamResult = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second exam result: ");
            double secondExamResult = Convert.ToDouble(Console.ReadLine());
            double Result  = ExamResult(firstExamResult, secondExamResult);
            Console.WriteLine("The average of the two exam results is: {0}", Result);
            if (Result < 50)
            {
                Console.WriteLine("You have failed the exam.");
            }
            else
            {
                Console.WriteLine("You have passed the exam.");

            }
        }
    }
}
