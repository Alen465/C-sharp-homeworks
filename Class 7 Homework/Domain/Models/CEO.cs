using Domain.Enums;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }

        public double SharesPrice { get; private set; }

        public CEO(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            Employee[] employees,
            int shares)
            : base(id, firstName, lastName, age, salary, seniority)
        {
            Employees = employees;
            Shares = shares;
        }

        public void UpdateSharesPrice(double amount)
        {
            SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            foreach (Employee e in Employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
            }
        }

        public override double CalculateAnnualBonus()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}