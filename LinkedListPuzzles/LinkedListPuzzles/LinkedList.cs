using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    //Implement a LinkedList as a stack (LIFO / Last In, First Out)
    //Implement a singly linked list as a stack (Push, Pop, Clear, Count, Peek)
    public class LinkedListStack
    {
        private Node Head;
        public int Count { get; private set; }

        public LinkedListStack()
        {
            this.Head = null;
        }

        //We are adding before the head to implement as a stack (Each new node added becomes the head)
        public void Push(object x)
        { 
            Node n = new Node(x);
            n.Next = Head;
            this.Head = n;
            Count++;
        }

        public object Pop()
        { 
            object result;
            if (Head == null)
                //This is how the C# Stack implementation in System.Collections handles popping an empty stack
                throw new InvalidOperationException("Stack empty");
            else
            {
                result = Head.Data;
                this.Head = Head.Next;
                return result;
            }
        }

        //Returns the next object in the stack while not popping it off the stack
        public object Peek()
        {
            return Head.Data;
        }

        //Clears the Stack, resets the count
        public void Clear()
        {
            this.Head = null;
            Count = 0;
        }
        ////Call in Program.cs to test
        //LinkedListStack list = new LinkedListStack();
        //list.Push("pushed first");
        //list.Push("pushed last");
        //Console.WriteLine(list.Count);
        //Console.WriteLine(list.Pop());
        ////Output should be:
        ////2
        ////pushed last
    }
}
