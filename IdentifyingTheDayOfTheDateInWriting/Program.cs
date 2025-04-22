namespace IdentifyingTheDayOfTheDateInWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in the format DD/MM/YYYY:");
            string input = Console.ReadLine();
            string[] dateParts = input.Split('/');
            if (dateParts.Length != 3)
            {
                Console.WriteLine("Invalid date format. Please use DD/MM/YYYY.");
                return;
            }
            int day, month, year;
            if (!int.TryParse(dateParts[0], out day) || !int.TryParse(dateParts[1], out month) || !int.TryParse(dateParts[2], out year))
            {
                Console.WriteLine("Invalid date format. Please use DD/MM/YYYY.");
                return;
            }
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1)
            {
                Console.WriteLine("Invalid date. Please enter a valid date.");
                return;
            }
            string[] days = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth",
                              "eleventh", "twelfth", "thirteenth", "fourteenth", "fifteenth", "sixteenth",
                              "seventeenth", "eighteenth", "nineteenth", "twentieth", "twenty-first",
                              "twenty-second", "twenty-third", "twenty-fourth", "twenty-fifth",
                              "twenty-sixth", "twenty-seventh", "twenty-eighth", "twenty-ninth",
                              "thirtieth", "thirty-first" };
            string[] months = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };
            string dayInWords = (day > 0 && day <= 31) ? days[day - 1] : "Invalid";
            string monthInWords = (month > 0 && month <= 12) ? months[month - 1] : "Invalid";
            string yearInWords = year.ToString();
            string dateInWords = $"{dayInWords} of {monthInWords} {yearInWords}";
            Console.WriteLine($"The date in words is: {dateInWords}");
        }
    }
}
