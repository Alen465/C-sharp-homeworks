using Domain.Enums;
using Domain.Models;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer(
                1, "Bob", "Bobsky", 28, 3000,
                Seniority.Junior, "C#");

            Developer dev2 = new Developer(
                2, "John", "Johnsky", 30, 3500,
                Seniority.Senior, "Java");

            Manager manager1 = new Manager(
                3, "Sarah", "Smith", 40, 5000,
                Seniority.Lead, "IT");

            Manager manager2 = new Manager(
                4, "Mike", "Johnson", 38, 4800,
                Seniority.Senior, "HR");

            Contractor contractor = new Contractor(
                5, "David", "Williams", 29, 2000,
                Seniority.Junior, 160, 25, manager1);

            Employee[] employees =
            {
                dev1, dev2, manager1, manager2, contractor
            };

            CEO ceo = new CEO(
                6, "Alice", "Alison", 35, 8000,
                Seniority.Lead, employees, 500);

            ceo.UpdateSharesPrice(41);

            Console.WriteLine(ceo.GetDetails());

            Console.WriteLine();
            Console.WriteLine("Employees:");

            ceo.PrintEmployees();

            Console.WriteLine();

            Console.WriteLine("CEO Annual Bonus: " + ceo.CalculateAnnualBonus());

            Console.ReadLine();
        }
    }
}