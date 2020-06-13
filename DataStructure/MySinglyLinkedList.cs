using System;
namespace ProblemSolving.DataStructure.LinkedList
{
    public class MySinglyLinkedList
    {
        internal class Node
        {
            public object Data;
            public Node Next;

            public Node(object data)
            {
                Data = data;
                Next = null;
            }
        }
        public class MyLinkedList
        {
            Node Head = null;
            public void PrintAllNodes()
            {
                Node current = Head;
                if (current == null)
                {
                    Console.WriteLine("Empty Linked List");
                }
                else
                {
                    while (current != null)
                    {
                        Console.Write(current.Data + "->");
                        current = current.Next;
                    }
                }
            }
            public void AddFirst(Object data)
            {
                if (Head == null)
                {
                    Head = new Node(data);
                    Head.Data = data;
                    Head.Next = null;
                }
                else
                {
                    Node toAdd = new Node(data);
                    toAdd.Next = Head;
                    Head = toAdd;
                }

            }
            public void AddLast(Object data)
            {
                if (Head == null)
                {
                    Head = new Node(data);

                    Head.Data = data;
                    Head.Next = null;
                }
                else
                {
                    Node toAdd = new Node(data);
                    Node current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = toAdd;
                }
            }

            public int Size()
            {
                int count = 0;
                Node current = Head;
                if (current == null)
                {
                    return 0;
                }
                else
                {
                    while (current != null)
                    {
                        current = current.Next;
                        count++;
                    }
                }
                return count;
            }
            public void ReverseLinkedList(MyLinkedList linkedList)
            {
                Node current = linkedList.Head;
                Node prev = null;
                Node temp = null;

                while (current.Next != null)
                {
                    temp = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = temp;
                }
                linkedList.Head = prev;
            }

            //reverseList() will reverse the singly linked list and return the head of the list  
            private Node Reverse(Node temp)
            {
                Node current = temp;
                Node prevNode = null, nextNode = null;

                //Swap the previous and next nodes of each node to reverse the direction of the list  
                while (current != null)
                {
                    nextNode = current.Next;
                    current.Next = prevNode;
                    prevNode = current;
                    current = nextNode;
                }
                return prevNode;
            }
            public void IsPallindrome(MyLinkedList linkedList)
            {
                Node currnt = linkedList.Head;
                Boolean flag = true;
                int size = linkedList.Size();
                int mid = (size % 2 == 0) ? (size / 2) : (size + 1 / 2);

                //Finds the middle node in given singly linked list  
                for (int i = 1; i < mid; i++)
                {
                    currnt = currnt.Next;
                }

                //Reverse the list after middle node to end  

                Node revHead = Reverse(currnt.Next);

                //Compare nodes of first half and second half of list  
                while (Head != null && revHead != null)
                {
                    if (!(Head.Data.Equals(revHead.Data)))
                    {
                        flag = false;
                        break;
                    }
                    Head = Head.Next;
                    revHead = revHead.Next;
                }

                if (flag)
                    Console.WriteLine("\nGiven singly linked list is a palindrome");
                else
                    Console.WriteLine("\nGiven singly linked list is not a palindrome");
            }

        }
    }

}
