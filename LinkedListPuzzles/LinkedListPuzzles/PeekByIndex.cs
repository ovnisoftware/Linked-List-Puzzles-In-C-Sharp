using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Implement PeekByIndex(forward)) for a linked list
        //Peeks a certain number of nodes ahead, 1 returns head.Data, 2 returns the second node's data, etc. without removing items from the list
        public int PeekByIndex(int x)
        {
            if ((x < 1) || (x > Count))
                throw new Exception("Index out of range");
            Node cur = head;
            for (int i = 1; i < x; i++)
                cur = cur.Next;
            return (int)cur.Data;
        }
        //var s = new LinkedListStack();
        //s.Push(1);
        //s.Push(2);
        //s.Push(3);
        //s.Push(4);
        //s.Push(5);
        //s.Push(6);
        //s.Push(7);
        //Console.WriteLine(s.PeekByIndex(7));
        //s.CallReversePrint();
    }
}
