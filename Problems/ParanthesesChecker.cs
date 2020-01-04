using System;
using System.Collections;
using System.Collections.Generic;



namespace ConsoleApplication1
{
    /// <summary>
    /// Check the parenthesis in an expression and verify it's Validity
    /// </summary>
    public class ParanthesesChecker
    {
        static void Main()
        {
            string testData1 = "(){}";
            Console.WriteLine($"Parentheses Checker result : {IsParanthesesMatched(testData1)}");

            string testData2 = "{(a+b)*(c-d)}";
            Console.WriteLine($"Parentheses Checker result : {IsParanthesesMatched(testData2)}");

            string testData3 = "{[a+b]-(d-e)+{z-x)}";
            Console.WriteLine($"Parentheses Checker result : {IsParanthesesMatched(testData3)}");

            string testData4 = "{(a+b)*(c+d)";
            Console.WriteLine($"Parentheses Checker result : {IsParanthesesMatched(testData4)}");
            Console.ReadLine();

            string testData5 = "{{))";
            Console.WriteLine($"Parentheses Checker result : {IsParanthesesMatched(testData5)}");
        }

        public static bool IsParanthesesMatched(string expresion)
        {
            char[] chars = expresion.ToCharArray();
            Stack stack = new Stack();
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            dictionary.Add('(', ')');
            dictionary.Add('[', ']');
            dictionary.Add('{', '}');

            foreach (var item in chars)
            {
                if (dictionary.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else if (dictionary.ContainsValue(item))
                {
                    // Check if the closing bracket matching with the latest opening bracket
                    char latestOpeningbracket = char.Parse(stack.Peek().ToString());
                    if (item == dictionary[latestOpeningbracket])
                    {
                        stack.Pop();
                    }
                    else if (stack.Count > 0)
                    {
                        break;
                    }

                }
           }
            return stack.Count == 0 ? true : false;


        }

    }
}
