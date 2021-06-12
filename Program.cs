using System;

namespace Homework_Week_3_Lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("This is the App counting your age!");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Podaj swój rok urodzenia: ");
            int yearOfBirth = GetYear();
            Console.WriteLine();

            Console.Write("Podaj miesiąc swoich urodzin: ");
            int monthOfBirth = GetMonth();
            Console.WriteLine();

            Console.Write("Podaj dzień swoich urodzin: ");
            int dayOfBirth = GetDay(monthOfBirth, yearOfBirth);
            Console.WriteLine();

            Console.Write("Podaj miejsce urodzenia: ");
            var placeOfBirth = Console.ReadLine();
            Console.WriteLine();


            //Logic
            int age = 0;

            age = DateTime.Now.Year - yearOfBirth;
            DateTime dt = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            if (DateTime.Now.DayOfYear > dt.DayOfYear )
            {
                age--;
            }

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Cześć {name}, urodziłeś się w {placeOfBirth} i masz {age} lat.");
            Console.ForegroundColor = prevColor;

            Console.ReadLine();

        }

        private static int GetDay(int month, int year)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > DateTime.DaysInMonth(year, month))
                {
                    Console.WriteLine("Wrong Input! Try again!");
                    Console.Write("Podaj dzień swoich urodzin: ");
                    continue;
                }
                return day;
            }
        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("Wrong input, try again!");
                    Console.Write("Podaj miesiąc swoich urodzin: ");
                    continue;
                }
                return month;
            }

        }

        private static int GetYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year < 1900 || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Wrong value, try again...");
                    Console.Write("Podaj swój rok urodzenia: ");
                    continue;
                }
                return year;
            }
  
        }
    }
}
