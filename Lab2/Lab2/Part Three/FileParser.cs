using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2.Part_Three
{
    public static class FileParser
    {
        private static string _filePath;
        private static Type _type;
        private static Data CreateObject(string[] arguments)
        {
            Data x = (Data)Activator.CreateInstance(_type);
            x.SetParameters(arguments);
            return x;
        }

        public static List<Data> ParseFile(string filePath, Type type)
        {
            _filePath = filePath;
            _type = type;

            return ReadFromFile();
        }

        private static List<Data> ReadFromFile()
        {
            StreamReader reader = File.OpenText(_filePath);
            string line;


            List<Data> result = new List<Data>();
            reader.ReadLine();
            while ((line = reader.ReadLine()) != null && AdditionalVerification(line) )
            {
                string[] splitedLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (splitedLine.Length != 0 && Char.IsDigit(splitedLine[0][0]))
                {
                    Data element = CreateObject(splitedLine);
                    result.Add(element);
                }
            }

            return result;
        }


        public static bool AdditionalVerification(string line)
        {
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
