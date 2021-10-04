using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            Employee architect = new Architect(Guid.NewGuid(), "Ionut", "Popa", new DateTime(2010, 5, 21), new DateTime(2022, 6, 24), 5000);
            Employee manager = new Manager(Guid.NewGuid(), "Andrei", "Ciobanu", new DateTime(2018, 3, 11), new DateTime(2020, 4, 16), 4500);
            architect.Salutation();
            Console.WriteLine("Is " + architect.GetType().Name.ToLower() + " " + architect.GetFullName() + " active? " + architect.IsActive());
            manager.Salutation();
            Console.WriteLine("Is " + manager.GetType().Name.ToLower() + " " + manager.GetFullName() + " active? " + manager.IsActive());


            Console.WriteLine();
            Console.WriteLine("2.");
            string sentence = "The lazy brown fox doesn't jump over the dog";
            sentence.ComputeWords();
        }
    }
}