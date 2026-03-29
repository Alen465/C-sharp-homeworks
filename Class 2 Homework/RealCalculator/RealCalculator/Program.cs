using System;

class RealCalculator
{
    static void Main()
    {
        Console.Write("Enter the First number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        if (operation == '+')
        {
            result = num1 + num2;
        }
        else if (operation == '-')
        {
            result = num1 - num2;
        }
        else if (operation == '*')
        {
            result = num1 * num2;
        }
        else if (operation == '/')
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation!");
            return;
        }

        Console.WriteLine("The result is: " + result);
    }
}