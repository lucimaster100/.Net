using System;
using System.Collections.Generic;

namespace Lab2
{
    public class SolutionOne
    {
        public readonly List<Weather> _wearherInfo;
        public SolutionOne(string filePath)
        {
            WeatherFileParser parser = new WeatherFileParser(filePath);
            this._wearherInfo = parser.ParseWeatherInfo();
        }

        public void printSolution()
        {
            int day, maxTemp, minTemp, day1=-1, min=Int32.MaxValue;
            
            foreach (Weather wh in _wearherInfo)
            {
                
                day = wh.Day;
                maxTemp = wh.MaxTemp;
                minTemp = wh.MinTemp;
                if (maxTemp - minTemp < min)
                {
                    min = maxTemp - minTemp;
                    day1 = day;
                    
                }
                
                    
            }
            Console.WriteLine();
            Console.Write("day: ");
            Console.Write(day1);
            Console.Write(" spread: ");
            Console.WriteLine(min);
            Console.WriteLine();
        }
    }
}