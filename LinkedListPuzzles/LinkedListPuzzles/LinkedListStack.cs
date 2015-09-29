using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    //Implement a LinkedList as a stack (LIFO / Last In, First Out)
    //Implement a singly linked list as a stack (Push, Pop, Clear, Count, Peek)
    public partial class LinkedListStack
    {
        private Node head;
        public int Count { get; private set; }

        public LinkedListStack()
        {
            head = null;
        }

        //We are adding before the head to implement as a stack (Each new node added becomes the head)
        //O(1) time complexity
        public void Push(object x)
        { 
            Node n = new Node(x);
            n.Next = head;
            this.head = n;
            Count++;
        }

        //O(1) time complexity
        public object Pop()
        { 
            object result;
            if (head == null)
                //This is how the C# Stack implementation in System.Collections handles popping an empty stack
                throw new InvalidOperationException("Stack empty");
            else
            {
                result = head.Data;
                this.head = head.Next;
                return result;
            }
        }

        //Returns the next object in the stack while not popping it off the stack
        public object Peek()
        {
            return head.Data;
        }

        //Clears the Stack, resets the count
        public void Clear()
        {
            head = null;
            Count = 0;
        }
            ////Call in Program.cs to test
            //LinkedListStack list = new LinkedListStack();
            //list.Push("pushed first");
            //list.Push("pushed last");
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Pop());
            //Console.WriteLine(list.Pop());
    }
}
