using System;

namespace Lab2
{
    public class Weather
    {
        public int Day { get; }
        public int MaxTemp { get; }
        public int MinTemp { get; }
        
        public Weather(int day, int maxTemp, int minTemp)
        {
            if (day > 0)
            {
                Day = day;
                MaxTemp = maxTemp;
                MinTemp = minTemp;
            }
            else
            {
                throw new ArgumentException("Day can't be negative");
            }

        }
    }
}