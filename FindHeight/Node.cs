﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindHeight.Classes
{
    public class Node
    {

        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }
        public int Root { get; set; }


        public Node(int v)
        {
            Root = v;
        }

    }

}
