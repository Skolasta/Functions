namespace Calculator
{
    internal class Program
    {
        static int BasicMath(int num1,int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return 0;
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Invalid operation.");
                    return 0;
            }
        }
        static double AdvancedMath(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "pow":
                    return (double)Math.Pow(num1, num2);
                case "mod":
                    return num1 % num2;
                
                default:
                    Console.WriteLine("Invalid operation.");
                    return 0;
            }
        }
        static void Advanced2(double num, string operation)
        {
            switch (operation)
            {
                case "sqrt": // Square root
                    if (num < 0)
                    {
                        Console.WriteLine("Cannot calculate square root of a negative number.");
                    }
                    else
                    {
                        Console.WriteLine($"Square root of {num}: {Math.Sqrt(num)}");
                    }
                    break;

                case "abs": // Absolute value
                    Console.WriteLine($"Absolute value of {num}: {Math.Abs(num)}");
                    break;

                case "prime factors": // Prime factors
                    Console.WriteLine($"Prime factors of {num}:");
                    for (int i = 2; i <= num; i++)
                    {
                        while (num % i == 0)
                        {
                            Console.Write(i + " ");
                            num /= i;
                        }
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        static int Factorial(int num1) // factorial
        {
            if (num1 < 0)
            {
                Console.WriteLine("Cannot calculate factorial of a negative number.");
                return 0;
            }
            if (num1 == 0 || num1 == 1)
                return 1;
            return num1 * Factorial(num1 - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please select the operation you want to perform: + - * / mod pow sqrt abs prime factors factorial");
            string operation = Console.ReadLine();
            if (operation == "sqrt" || operation == "abs" || operation == "prime factors")
            {
                Console.WriteLine("Please enter the number:");
                double num = double.Parse(Console.ReadLine());
                Advanced2(num, operation);
            }
            else if (operation == "factorial")
            {
                Console.WriteLine("Please enter the number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Factorial of " + num1 + " is: " + Factorial(num1));
            }
            else if (operation == "mod" || operation == "pow")
            {
                Console.WriteLine("Please enter the first number:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + AdvancedMath(num1, num2, operation));
            }
            else
            {
                Console.WriteLine("Please enter the first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + BasicMath(num1, num2, operation));
            }
        }
    }
}
