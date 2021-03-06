﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPuzzles
{
    //Stores the object and pointer to the next node in the list
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object x)
        {
            Data = x;
            Next = null;
        }
    }
}
