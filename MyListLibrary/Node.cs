using System;
using System.Collections.Generic;
using System.Text;

namespace MyListLibrary
{
    public class Node
    {
        public Node(float number)
        {
            this.Number = number;
            this.Next = null!;

        }
        public float Number { get; private set; }
        public Node Next { get; set; }
    }
}
