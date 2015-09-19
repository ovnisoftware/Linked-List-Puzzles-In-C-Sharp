using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Reverse a singly linked list using iteration
        public void Reverse()
        {
            //Return if the list has less than 2 nodes
            if (Head == null || Head.Next == null)
                return;

            //Use trailing nodes to reverse the pointers
            Node lag = Head;
            Node lead = Head.Next;
            lag.Next = null;
            
            while (lead.Next != null)
            {
                Node temp = lead.Next;
                lead.Next = lag;
                lag = lead;
                lead = temp;
            }
            //Set the head to the last node in the list
            Head = lead;
            Head.Next = lag;
        }
        ////Run in Program.cs to test
        //LinkedListStack list = new LinkedListStack();
        //list.Push(1);
        //list.Push(2);
        //list.Push(3);
        //list.Push(4);
        //list.Reverse();
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list.Pop());
    }
}