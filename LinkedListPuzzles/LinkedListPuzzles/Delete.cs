using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Deletes nth item from head (Ex. passing a 1 deletes the head node)
        public void Delete(int x)
        {
            if ((x> Count) || (x<1))
                throw new Exception("Out of range");

            if (x == 1)
            {
                head = head.Next;
                return;
            }
            Node lag = head;
            Node lead = head.Next;
            //lag Node will point at the node before the Node we want to delete, lead is set to the node
            //set to be deleted
            for (int i = 2; i < x; i++)
            {
                lag = lag.Next;
                lead = lead.Next;
            }
            //Skip the node to be deleted
            lag.Next = lead.Next;
        }
    }
    ////Run in Program.cs to test
    //LinkedListStack list = new LinkedListStack();
    //list.Push(1);
    //list.Push(2);
    //list.Push(3);
    //list.Push(4);
    //list.Delete(3);
    //Console.WriteLine(list.Pop());
    //Console.WriteLine(list.Pop());
    //Console.WriteLine(list.Pop());
    ////Output should be: (3rd node from front is deleted)
    ////4
    ////3
    ////1
}
