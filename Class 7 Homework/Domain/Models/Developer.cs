using Domain.Enums;

namespace Domain.Models
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            string programmingLanguage)
            : base(id, firstName, lastName, age, salary, seniority)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Programming Language: {ProgrammingLanguage}";
        }

        public override double CalculateAnnualBonus()
        {
            return Salary * 0.3;
        }
    }
}