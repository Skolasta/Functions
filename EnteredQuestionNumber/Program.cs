namespace EnteredQuestionNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soru Numarasını Giriniz: ");
            int qNum = int.Parse(Console.ReadLine());
            if (qNum == 1)
            {

                Console.WriteLine("Enter numbers with a space ");
                string input = Console.ReadLine();
                int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int maxNum = numbers[0];
                int minNum = numbers[0];
                int maxIndex = 0, minIndex = 0, tempMin = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > maxNum)
                    {
                        maxNum = numbers[i];
                        maxIndex = i;
                    }
                    if (numbers[i] < minNum)
                    {
                        minNum = numbers[i];
                        minIndex = i;
                    }
                }
                tempMin = numbers[minIndex];
                numbers[minIndex] = numbers[maxIndex];
                numbers[maxIndex] = tempMin;
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }

                Console.Read();


            }
            else if (qNum == 2)
            {

                int num = 0, sum = 0;
                do
                {
                    Console.WriteLine("Enter a number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        continue;
                    }
                    sum += num;
                    Console.Write(num + " ");
                }
                while (num >= 0);
                Console.Write("Total: {0}", sum);

            }
        }
    }
}
