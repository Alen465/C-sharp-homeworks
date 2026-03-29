using System;

class AverageNumber
{
    static void Main()
    {
        Console.Write("Enter the First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2 + num3 + num4;
        int average = sum / 4;

        Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
    }
}