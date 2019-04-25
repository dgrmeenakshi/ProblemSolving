using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolving.Problems
{
    // read the string from file and find out the highest occurences of the string.
    public class HighestRepeaterStringFinder
    {
        
        public static void Execute()
        {
            string str = ReadFromFile();
            //split the string into arrays of string
            string[] arr = ConvertStringToArray(str);

            // Count the no.of times a word has repaeated
            CountWordsRepeatition(arr);

            // Sort the dictionary as per value

            SortbyValue(CountWordsRepeatition(arr));
            Console.ReadLine();
        }
    public static string ReadFromFile()
    {
        string line, wholeContent = string.Empty;
        string filePath = @"C:\Temp\data.txt";
        StreamReader sr = new StreamReader(filePath);
        while ((line = sr.ReadLine()) != null)
        {
            wholeContent = wholeContent + line + " ";
        }
        return wholeContent;
    }
    public static string[] ConvertStringToArray(string str)
    {
        string[] arr = str.Split(' ');
        return arr;
    }

    public static Dictionary<string, int> CountWordsRepeatition(string[] arr)
    {
        Dictionary<string, int> dc = new Dictionary<string, int>();
        foreach (var word in arr)
        {
            if (dc.ContainsKey(word.ToString()))
            {
                dc[word.ToString()]++;
            }
            else
            {
                dc.Add(word.ToString(), 1);
            }

        }
        foreach (KeyValuePair<string, int> kvp in dc)
        {
            Console.Write("\n WORD : {0} , COUNT : {1} ", kvp.Key, kvp.Value);
            Console.WriteLine();

        }
        return dc;
    }

    public static void SortbyValue(Dictionary<string, int> dc)
    {
            int count = 0;
            // Sort
            foreach (var item in dc.OrderByDescending(r => r.Value).Take(1))
                {
                if (count < item.Value)
                    count = item.Value;
                Console.WriteLine("\nHighest occurence of WORD : {0} &&  Count  is  : {1}", item.Key, count);
            }
           
        }

}
}