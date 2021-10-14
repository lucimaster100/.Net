using System;
using System.Collections.Generic;

namespace Lab2.Part_Three
{
    public class Weather : Data
    {
        public int Day { get; set; }
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }

        public Weather()
        {
        }

        public void SetParameters(string[] arguments)
        {
            Day = Int32.Parse(arguments[0]);
            MaxTemp = Int32.Parse(arguments[1]);
            MinTemp = Int32.Parse(arguments[2]);
        }
    }
}
