

using System;
using System.Collections.Generic;

namespace Lab2.Part_Three
{
    public class SolutionProviderWeather
    {
        public readonly List<Weather> _wearherInfo;
        public SolutionProviderWeather(string filePath)
        {
            List<Data> dataObjects = FileParser.ParseFile(filePath, typeof(Weather));

            this._wearherInfo = new List<Weather>();
            foreach (Data e in dataObjects)
            {
                _wearherInfo.Add((Weather)e);
            }
        }

        public void ShowSmallestWeatherDifference()
        {
            int day, maxTemp, minTemp, day1 = -1, min = Int32.MaxValue;

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
            Console.Write("The day with the minimum spread: ");
            Console.Write("day: ");
            Console.Write(day1);
            Console.Write(" spread: ");
            Console.WriteLine(min);
            Console.WriteLine();
        }
    }
}
