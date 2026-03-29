using System;

class SwapNumbers
{
    static void Main()
    {
        Console.Write("Input the First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("First Number: " + num1);
        Console.WriteLine("Second Number: " + num2);
    }
}