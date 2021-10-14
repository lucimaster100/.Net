using System;
using System.Collections.Generic;

namespace Lab2.Part_Two
{
    public class SolutionProvider
    {
        private readonly List<TeamResults> _teamResultsList;
        

        public SolutionProvider(string filePath)
        {
            FootballFileParser parser = new FootballFileParser(filePath);
            this._teamResultsList = parser.ParseTeamResults();

        }

        public List<(TeamResults,int)> GoalDifferenceRanking()
        {
            List <(TeamResults, int)> resultList = new List<(TeamResults, int)>();
            foreach (TeamResults result in this._teamResultsList)
            {
                resultList.Add((result, Math.Abs(result.GoalsFor - result.GoalsAgainst)));
                
            }
            //sort the list of tuples by the second value
            resultList.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            return resultList;
        }

        public void ShowRankingByGoalDifference()
        {
            List<(TeamResults, int)> differenceList = GoalDifferenceRanking();
            Console.WriteLine("Team name" + " --> " + "Goal difference");
            Console.WriteLine("----------------------------");
            foreach ((TeamResults, int) entry in differenceList)
            {
                Console.WriteLine(entry.Item1.Team + " --> " + entry.Item2);

            }

        }

        public void GetTeamWithSmallestDifference()
        {
            List<(TeamResults, int)> list = GoalDifferenceRanking();
            Console.WriteLine("The team that has the smallest difference in 'for' and 'against' goals: " + list[0].Item1.Team); 
        }

    }
}