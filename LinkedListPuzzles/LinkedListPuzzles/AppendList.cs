using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    //Append one linked list to another linked list
    public static class AppendList
    {
        //Iterate through first list until you get to end
        //Set pointer of last node in first list equal to head of list2
        public static void Append(LinkedListStack list1, LinkedListStack list2)
        {
            Node cur = list1.head;
            while (cur.Next != null)
                cur = cur.Next;
            cur.Next = list2.head;
        }
        //LinkedListStack s1 = new LinkedListStack();
        //s1.Push(1);
        //s1.Push(2);
        //s1.Push(3);
        //LinkedListStack s2 = new LinkedListStack();
        //s2.Push(4);
        //s2.Push(5);
        //s2.Push(6);
        //AppendList.Append(s1, s2);
        //Console.WriteLine(s1.Pop());
        //Console.WriteLine(s1.Pop());
        //Console.WriteLine(s1.Pop());
        //Console.WriteLine(s1.Pop());
        //Console.WriteLine(s1.Pop());
        //Console.WriteLine(s1.Pop());
    }
}
