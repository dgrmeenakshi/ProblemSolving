using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvings
{
    public class CreateAndAddTwoLinkedList
    {
        public static void AddLinkedList()
        {
            int temp, carry = 0;
            LinkedList<int> listA = new LinkedList<int>();
            listA.AddFirst(8);
            listA.AddFirst(4);
            foreach (var i in listA)
            {
                Console.Write(i);
            }
            LinkedList<int> listB = new LinkedList<int>();
            listB.AddFirst(7);
            listB.AddFirst(5);
            listB.AddFirst(9);
            listB.AddFirst(4);
            listB.AddFirst(6);
            Console.WriteLine();
            foreach (var v in listB)
            {
                Console.Write(v);
            }
            Console.WriteLine();

            LinkedList<int> resultList = new LinkedList<int>();// Create an empty linked list 
                // ------------ADD TWO LINKED LISTS--------------------------------
            int l1Len = listA.Count;
            int l2Len = listB.Count;
            
            int count = listA.Count > listB.Count ? listA.Count : listB.Count;
            for (int i = count-1; i >-1; i--)
            {
                temp = listA.ElementAtOrDefault(i) + listB.ElementAtOrDefault(i);
                resultList.AddFirst((temp + carry) % 10);
                carry = (temp + carry) / 10;
            }
            foreach (var item in resultList)
            {
                Console.Write(item);
            }
        }
    }
}


