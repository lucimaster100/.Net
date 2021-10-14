using System;

namespace Lab2.Part_Three
{
    public class Team : Data
    {
        public string Name { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

        public Team()
        {
           
        }

        public void SetParameters(string[] arguments)
        {
            Name = arguments[1];
            GoalsFor = Int32.Parse(arguments[6]);
            GoalsAgainst = Int32.Parse(arguments[8]);
        }
    }
}
