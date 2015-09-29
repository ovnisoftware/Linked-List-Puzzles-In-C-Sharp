using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Worst case time complexity is O(n) if insertion is at end of list
        //Passing a 1 for position adds object at head (it becomes first in the stack)
        //passing the stack (count + 1) for position adds the inserted node at the end
        //of the linked list stack, 0 is considered an invalid index
        public void Insert(int position, object x)
        {
            if ((position < 1) || (position > Count + 1))
                throw new IndexOutOfRangeException("Invalid index");
            if (position == 1)
            {
                this.Push(x);
                return;
            }

            //Set two pointer nodes to first and second position
            Node lag = head;
            Node lead = head.Next;
            Node toInsert = new Node(x);

            //Set the pointers to the nodes immediately before and after the inserted node
            for (int i = 2; i < position; i++)
            {
                lag = lag.Next;
                lead = lead.Next;
            }
            //Make the insertion
            lag.Next = toInsert;
            toInsert.Next = lead;
        }
        ////Call in Program.cs to test
        //LinkedListStack list = new LinkedListStack();
        //list.Push("pushed first");
        //list.Push("pushed last");
        //list.Insert(2, "inserted");
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list.Pop());
        //Console.WriteLine(list.Pop());
    }
}
