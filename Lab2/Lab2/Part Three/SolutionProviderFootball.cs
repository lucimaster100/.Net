using System;
using System.Collections.Generic;

namespace Lab2.Part_Three
{
    public class SolutionProviderFootball
    {
        private readonly List<Team> _teamResultsList;


        public SolutionProviderFootball(string filePath)
        {
            List<Data> dataObjects = FileParser.ParseFile(filePath, typeof(Team));

            this._teamResultsList = new List<Team>();
            foreach (Data e in dataObjects)
            {
                _teamResultsList.Add((Team)e);
            }
        }

        public List<(Team, int)> GoalDifferenceRanking()
        {
            List<(Team, int)> resultList = new List<(Team, int)>();
            foreach (Team result in this._teamResultsList)
            {
                resultList.Add((result, Math.Abs(result.GoalsFor - result.GoalsAgainst)));

            }
            resultList.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            return resultList;
        }

        public void ShowRankingByGoalDifference()
        {
            List<(Team, int)> differenceList = GoalDifferenceRanking();
            Console.WriteLine("Name name" + " --> " + "Goal difference");
            Console.WriteLine("----------------------------");
            foreach ((Team, int) entry in differenceList)
            {
                Console.WriteLine(entry.Item1.Name + " --> " + entry.Item2);

            }
        }

        public void GetTeamWithSmallestDifference()
        {
            List<(Team, int)> list = GoalDifferenceRanking();
            Console.WriteLine("The team that has the smallest difference in 'for' and 'against' goals: " + list[0].Item1.Name);
        }
    }
}
