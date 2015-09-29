using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    partial class LinkedListStack
    {
        //Write a method to print a singly list backwards using recursion
        //Good Explanation here: https://www.youtube.com/watch?v=K7J3nCeRC80 MyCodeSchool Youtube Channel
        public void CallReversePrint()
        {
            ReversePrint(head);
        }

        public void ReversePrint(Node n)
        {
            if (n == null)
                return;
            ReversePrint(n.Next);
            Console.WriteLine(n.Data);
        }
    }
    ////Call in Program.cs to test
    //LinkedListStack list = new LinkedListStack();
    //list.Push(1);
    //list.Push(2);
    //list.Push(3);
    //list.Push(4);
    //list.CallReversePrint();
}