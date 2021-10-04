using System;

namespace Lab1
{
    public class Architect : Employee
    {
        public Architect(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) : base(id, firstName, lastName, startDate, endDate, salary)
        {
        }

        public override void Salutation()
        {
            Console.WriteLine("Hello, Architect!");
        }
    }
}