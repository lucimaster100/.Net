﻿using System;
using System.Collections.Generic;
using Lab2.Part_Two;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, mxT, mnT, day1=-1, min=Int32.MaxValue;
            int counter = 0;
            List<Weather> weatherList=new List<Weather>();
            String[] result;
  
// Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"weather.dat")) 
            {
                counter++;
                result = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (result.Length != 0)
                {
                    if (counter > 2 && counter<32)
                    {
                        Weather weather = new Weather(Int32.Parse(result[0]),
                    Int32.Parse(result[1]),
                    Int32.Parse(result[2]),
                    Int32.Parse(result[3]),
                    Int32.Parse(result[4]),
                    Double.Parse(result[5]),
                    Double.Parse(result[6]),
                    result[7].ToCharArray(),
                    Int32.Parse(result[8]),
                    Double.Parse(result[9]),
                    Int32.Parse(result[10]),
                    Int32.Parse(result[11]),
                    Double.Parse(result[12]),
                    Int32.Parse(result[13]),
                    Int32.Parse(result[14]),
                    Double.Parse(result[15]));
                        weatherList.Add(weather);
                    }
                    
                }
                
                
            }  
            foreach (var wh in weatherList)
            {
                day = wh.Dy;
                mxT = wh.MxT;
                mnT = wh.MnT;
                if (mxT - mnT < min)
                {
                    min = mxT - mnT;
                    day1 = day;
                }
                    
            }
            Console.Write("day: ");
            Console.Write(day1);
            Console.Write(" spread: ");
            Console.WriteLine(min);
            //SolutionProvider solution = new SolutionProvider("D:\\Repos\\.Net\\Lab2\\Lab2\\Part Two\\football.dat");
            SolutionProvider solution = new SolutionProvider("..\\..\\..\\Part Two\\football.dat");
            solution.ShowRankingByGoalDifference();
        }
    }
}