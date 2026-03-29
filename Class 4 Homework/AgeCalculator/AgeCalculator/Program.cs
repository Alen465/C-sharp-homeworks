using System;

class AgeCalculatorApp
{
    static void Main()
    {
        Console.Write("Enter your birthday (yyyy-mm-dd): ");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());

        int age = AgeCalculator(birthday);

        Console.WriteLine($"Your age is: {age}");
    }

    static int AgeCalculator(DateTime birthday)
    {
        DateTime today = DateTime.Today;

        int age = today.Year - birthday.Year;

        // If birthday hasn't happened yet this year, subtract 1
        if (birthday.Date > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }
}