using System;
using System.Collections.Generic;
using System.IO;
using Lab2.Part_Two;

namespace Lab2.Part_Three
{
    public class FileParser
    {
        private readonly string _filePath;

        public FileParser(string filePath)
        {
            this._filePath = filePath;
        }

        public List<TeamResults> ParseTeamResults()
        {
            StreamReader reader = File.OpenText(this._filePath);
            string line;


            List<TeamResults> result = new List<TeamResults>();
            reader.ReadLine(); //escape the first line
            while ((line = reader.ReadLine()) != null && AdditionalVerification(line))
            {
                string[] results = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                TeamResults currentTeam = new TeamResults(results[1], Int32.Parse(results[6]), Int32.Parse(results[8]));
                result.Add(currentTeam);

            }

            return result;
        }

        public static bool AdditionalVerification(string line)
        {
            //check the number of dashes ("-")
            //if the dash count on a line is greater than 1 we don't take the line into account
            int dashCount = 0;
            foreach (char chr in line)
            {
                if (chr == '-')
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
