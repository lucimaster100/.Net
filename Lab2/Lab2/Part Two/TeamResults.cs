using System;

namespace Lab2.Part_Two
{
    public class TeamResults
    {
        public string Team { get; }
        public int GoalsFor { get; }
        public int GoalsAgainst { get; }
        public TeamResults(string team, int goalsFor, int goalsAgainst)
        {
            if (goalsFor >= 0 && goalsAgainst >= 0)
            {
                Team = team;
                GoalsFor = goalsFor;
                GoalsAgainst = goalsAgainst;
            }
            else
            {
                throw new ArgumentException("Goals for and against can't be negative");
            }
        }
    }
}