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
            LinkedList<int> ls1 = new LinkedList<int>();
            ls1.AddFirst(8);
            ls1.AddFirst(4);
            foreach (var i in ls1)
            {
                Console.Write(i);
            }
            LinkedList<int> ls2 = new LinkedList<int>();
            ls2.AddFirst(7);
            ls2.AddFirst(5);
            ls2.AddFirst(9);
            ls2.AddFirst(4);
            ls2.AddFirst(6);
            Console.WriteLine();
            foreach (var v in ls2)
            {
                Console.Write(v);
            }
            Console.WriteLine();

            LinkedList<int> ls3 = new LinkedList<int>();// Create an empty linked list 
                // ------------ADD TWO LINKED LISTS--------------------------------
            int l1Len = ls1.Count;
            int l2Len = ls2.Count;

               

            int count = ls1.Count > ls2.Count ? ls1.Count : ls2.Count;
            for (int i = count-1; i >-1; i--)
            {
                temp = ls1.ElementAtOrDefault(i) + ls2.ElementAtOrDefault(i);
                ls3.AddFirst((temp + carry) % 10);
                carry = (temp + carry) / 10;
                
            }
            foreach (var item in ls3)
            {
                Console.Write(item);
            }

            }
        }
    }


