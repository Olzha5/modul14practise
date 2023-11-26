using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul14
{
    internal class Program
    {
     
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, " +
                          "Который построил Джек. А это веселая птица­-синица, Которая часто ворует пшеницу, " +
                          "Которая в темном чулане хранится В доме, Который построил Джек.";

            var wordCount = new Dictionary<string, int>();
            var words = text.Split(new char[] { ' ', '.', ',', '-', '­' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (wordCount.ContainsKey(lowerCaseWord))
                {
                    wordCount[lowerCaseWord]++;
                }
                else
                {
                    wordCount[lowerCaseWord] = 1;
                }
            }

            PrintWordCountTable(wordCount);
        }

        static void PrintWordCountTable(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("Слово\tКоличество");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}\t{pair.Value}");
            }
        }
    }

}

