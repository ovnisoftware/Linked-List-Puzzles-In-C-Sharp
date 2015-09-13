using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    //Write a function to detect a cycle in a linked list
    //The problem can be visualized by thinking of a Monopoly board game.  The squares the players land
    //on are like the nodes and the players are like the lag and lead pointers.  If you move the 
    //players at constant varying speeds (one player moves up one square and another player moves up
    //two squares) they will eventually land on the same square proving they are traveling in a circle.
    partial class LinkedListStack
    {
        //This creates a cycle by setting the last node's next property equal to the head
        public void CreateCycle()
        {
            Node cur = Head;
            while (cur.Next != null)
                cur = cur.Next;
            cur.Next = Head;
        }

        //Returns true if the list is an infinite loop, returns false if the list ends
        public bool DetectCycle()
        {
            //Create two pointers
            Node lag = Head;
            Node lead = Head.Next;

            //Move the lag pointer ahead one position in the list and move the leader ahead 2 positions
            while (lead.Next != null)
            {
                //If the two pointers point at the same object there is a cycle
                if (lag == lead)
                    return true;
                lag = lag.Next;
                for (int i = 0; i < 2; i++)
                {
                    //Checking here avoids NullReference exception
                    if (lead.Next == null)
                        return false;
                    lead = lead.Next;
                }
            }
            //If the lead pointer points at a null there is no cycle
            return false;
        }
        ////Call in Program.cs to test
        //LinkedListStack list = new LinkedListStack();
        //list.Push("pushed first");
        //list.Push("pushed second");
        //list.Push("pushed third");
        //Console.WriteLine(list.DetectCycle());
        //list.CreateCycle();
        //Console.WriteLine(list.DetectCycle());
    }
}
