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
        //Write a method to print a singly list forward using recursion
        //Good Explanation here: https://www.youtube.com/watch?v=K7J3nCeRC80 MyCodeSchool Youtube Channel
        public void CallInOrderPrint()
        {
            InOrderPrint(head);
        }

        public void InOrderPrint(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.Data);
            InOrderPrint(root.Next);
        }

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
    //LinkedListStack s = new LinkedListStack();
    //s.Push(1);
    //s.Push(2);
    //s.Push(3);
    //Console.WriteLine("In order");
    //s.CallInOrderPrint();
    //Console.WriteLine("Reverse");
    //s.CallReversePrint();
}