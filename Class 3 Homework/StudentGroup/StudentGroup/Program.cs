using System;

class StudentGroup
{
    static void Main()
    {
        string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
        string[] studentsG2 = { "Ana", "Bojan", "Mila", "Ivan", "Petar" };

        Console.Write("Enter student group (1 or 2): ");
        int group = Convert.ToInt32(Console.ReadLine());

        if (group == 1)
        {
            Console.WriteLine("The Students in G1 are:");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }
        }
        else if (group == 2)
        {
            Console.WriteLine("The Students in G2 are:");
            foreach (string student in studentsG2)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("Invalid group number!");
        }
    }
}