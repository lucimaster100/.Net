using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

namespace Lab2.Part_Two
{
    public class FootballFileParser
    {
        private readonly string _filePath;

        public FootballFileParser(string filePath)
        {
            this._filePath = filePath;
        }

        public List<TeamResults> ParseTeamResults()
        {
            //read line by line -> split on spaces
            StreamReader reader = File.OpenText(this._filePath);
            string line;
            List<TeamResults> teamResultsList = new List<TeamResults>();
            reader.ReadLine(); //escape the first line
            while ((line = reader.ReadLine()) != null && AdditionalVerification(line))
            {
                string[] results = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                TeamResults currentTeam = new TeamResults(results[1], Int32.Parse(results[6]), Int32.Parse(results[8]));
                teamResultsList.Add(currentTeam);

            }

            return teamResultsList;
        }

        public static bool AdditionalVerification(string line)
        {
            //check the number of dashes ("-")
            //if the dash count on a line is greater than 1 we don't take the line into account
            int dashCount = 0;
            foreach (char chr in line)
            {
                if (chr =='-')
                {
                    dashCount++;
                }
            }

            if (dashCount > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}