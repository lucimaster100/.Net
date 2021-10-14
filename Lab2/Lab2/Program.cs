using System;
using System.Collections.Generic;
using Lab2.Part_Two;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        //SolutionProvider solution = new SolutionProvider("D:\\Repos\\.Net\\Lab2\\Lab2\\Part Two\\football.dat");
        SolutionProvider solution = new SolutionProvider("..\\..\\..\\Part Two\\football.dat");
            solution.ShowRankingByGoalDifference();
        }
    }
}