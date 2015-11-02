using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Find nth to last element of a singly linked list implemented as a stack
        //1 returns the last object in the linked list
        public object FindNToLast(int x)
        {
            if (head == null)
                throw new Exception("Empty linked list");
            if (x < 1)
                throw new Exception("Index out of range");

            Node lag = head;
            Node lead = head;

            //Move the lead pointer up (x-1 positions) while leaving the lag pointer behind
            for (int i = 1; i < x; i++)
                lead = lead.Next;

            //Move the lag and lead pointers up one at a time until the lead is at the end of the list
            while (lead.Next != null)
            {
                lag = lag.Next;
                lead = lead.Next;
            }
            return lag.Data;
        }
        ////Run in Program.cs to test
        //LinkedListStack s = new LinkedListStack();
        //s.Push(1);
        //s.Push(2);
        //s.Push(3);
        //s.Push(4);
        //Console.WriteLine(s.FindNToLast(4));
    }
}
