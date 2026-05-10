using Domain.Enums;

namespace Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        protected double Salary { get; set; }
        public Seniority Seniority { get; set; }

        public Employee(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            Seniority = seniority;
        }

        public virtual string GetDetails()
        {
            return $"[{Id}] {FirstName} {LastName}, Age: {Age}, Salary: {Salary:C}, Seniority: {Seniority}";
        }

        public virtual double CalculateAnnualBonus()
        {
            return Salary * 0.1;
        }
    }
}