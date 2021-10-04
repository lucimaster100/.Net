using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public static class Extensions
    {
        public static void ComputeWords(this string sentence)
        {
            string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("#The sentence contains " + words.Length + " words");
        }
    }
}
