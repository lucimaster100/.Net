using System;
using System.Collections.Generic;

namespace Lab2
{
    public class WeatherFileParser
    {
        private readonly string _filePath;
        
        public WeatherFileParser(string filePath)
        {
            this._filePath = filePath;
        }

        public List<Weather> ParseWeatherInfo()
        {
            
            int counter = 0;
            List<Weather> weatherList=new List<Weather>();
            String[] result;
  

            foreach (string line in System.IO.File.ReadLines(_filePath)) 
            {
                counter++;
                result = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (result.Length != 0)
                {
                    if (counter > 2 && counter<32)
                    {
                        Weather weather = new Weather(Int32.Parse(result[0]),
                            Int32.Parse(result[1]),
                            Int32.Parse(result[2]));
                        weatherList.Add(weather);
                    }
                    
                }
            }

            return weatherList;
        }
    }
}