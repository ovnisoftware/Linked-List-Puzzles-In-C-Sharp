using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListPuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack s = new LinkedListStack();
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.TestDeleteMiddle(2);// .DeleteMid2(2);
            //s.TestDeleteMiddle(3); //Deletes 5 from the stack
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
        }
    }
}