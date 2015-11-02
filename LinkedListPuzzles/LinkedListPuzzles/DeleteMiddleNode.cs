using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Delete middle node in a linked list
        //This method will delete any passed node except for the last node
        //Attempting to delete the last node in this manner will not work
        public void DeleteMiddle(Node x)
        {
            if (x.Next == null)
                return;
            //Copy data from next node to passed node
            x.Data = x.Next.Data;
            //Set Next pointer to node after copied data
            x.Next = x.Next.Next;
        }

        //Passing 1 deletes the head Node
        public void TestDeleteMiddle(int nodeToDelete)
        {
            Node cur = head;
            for (int i = 1; i < nodeToDelete; i++)
                cur = cur.Next;
            //DeleteMiddle(cur);
            DeleteMiddle(cur);
        }
        ////Run in Program.cs to test
        //LinkedListStack s = new LinkedListStack();
        //s.Push(1);
        //s.Push(2);
        //s.Push(3);
        //s.Push(4);
        //s.Push(5);
        //s.Push(6);
        //s.Push(7);
        //s.TestDeleteMiddle(3); //Deletes 5 from the stack
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
    }
}
