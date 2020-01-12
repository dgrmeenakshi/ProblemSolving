using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.DataStructure.Stack
{
    class UserDefinedStack
    {
        private int top = 0;
        private int defaultSize = 16;
        private int[] stackArray;

        public UserDefinedStack()
        {
            stackArray = new int[defaultSize];
        }

        public UserDefinedStack(int size)
        {
            stackArray = new int[size];
        }

        public void Push(int data)
        {
            if (top > stackArray.Length)
            {
                throw new StackOverflowException();
            }
            stackArray[top] = data;
            top++;
        }
        public int Pop()
        {
            if (top < 0)
            {
                throw new InsufficientExecutionStackException();
            }
            top--;
            return stackArray[top + 1];
        }

        public int Peek()
        {
            return stackArray[top - 1];
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public int Size()
        {
            return top;
        }
    }
}
