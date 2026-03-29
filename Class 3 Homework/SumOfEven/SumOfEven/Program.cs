using System;

class SumOfEven
{
    static void Main()
    {
        int[] numbers = new int[6];
        int sumEven = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter integer no.{i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] % 2 == 0) // check if even
            {
                sumEven += numbers[i];
            }
        }

        Console.WriteLine("The result is: " + sumEven);
    }
}