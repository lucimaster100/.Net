using System;

namespace Lab1
{
    public abstract class Employee
    {
        private Guid id;
        private string firstName;
        private string lastName;
        private DateTime startDate;
        private DateTime endDate;
        private double salary;


        protected Employee(Guid id, string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.salary = salary;
        }
        

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public bool IsActive()
        {
            DateTime now=DateTime.Now;

            return (DateTime.Compare(startDate, now) < 0 && DateTime.Compare(now, endDate) < 0);
        }

        public abstract void Salutation();
    }
}