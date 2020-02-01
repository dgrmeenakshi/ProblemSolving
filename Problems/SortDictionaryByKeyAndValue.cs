using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Problems
{
    public class SortDictionaryByKeyAndValue
    {
        public void SortDicValueUsingLinq()
        {
            IDictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "abc");
            dic.Add(2, "asa");
            dic.Add(3, "aaa");
            dic.Add(4, "dss");
            dic.Add(5, "ase");
            dic.Add(6, "ere");

            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Sort the dictionary with respect to value");
            var sortedDicValue = dic.OrderBy(x => x.Value.ToString()).ToArray();

            foreach (var kvp in sortedDicValue)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }


        public void SortDicWithRespectToKey()
        {
            IDictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(5, "abc");
            dic.Add(2, "asa");
            dic.Add(45, "aaa");
            dic.Add(4, "dss");
            dic.Add(51, "ase");
            dic.Add(-1, "ere");
            Console.WriteLine("Sort the dictionary with respect to value");

            var dicValue = dic.Keys.ToArray();
            Array.Sort(dicValue);

            foreach (var key in dicValue)
            {
                Console.WriteLine($"Key :{key} Value :{dic[key]}");
            }
        }

    }
}

