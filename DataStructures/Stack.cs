using System;

namespace ProblemSolving.DataStructures
{
   public class Stack
    {
        private int _data;
        private int top = 0;
        private int defaultSize = 16;
        private int[] stackArray;

        public Stack()
        {
            stackArray = new int[defaultSize];
        }

        public Stack(int size)
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

