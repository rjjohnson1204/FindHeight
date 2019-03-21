using FindHeight.Classes;
using System;


namespace FindHeight
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //building of the tree
            Node node = new Node(0);
            node.LeftChild = new Node(0);
            node.RightChild = new Node(0);
            node.LeftChild.LeftChild = new Node(0);
            node.LeftChild.LeftChild.LeftChild = new Node(0);

            // outputs the max tree height
            Console.WriteLine(FindLevel(node));
        }

        //traverses the tree to
        public static int FindLevel(Node node)
        {
            // number of traversals
            int Counter = 0;
            // Level Level so far
            int Level = 0;

            //counter value will replace Level value if it is a larger value
            if (Counter < Level)
            {
                Level = Counter;
            
            }
            
            //checks to see if root is null
            if (node == null)
            {
                return 0;
            }
            // adds to counter when hit
            Counter ++; 

            //runs until node equals null
            if (node.Root != null)
            {
                // check to see if left child equals null
                if (node.LeftChild != null)
                {
                    // if not null run the method again
                    FindLevel(node.LeftChild);
                }

                //checks to see if right child equal null
                if (node.RightChild != null)
                {
                    //if not null run the method again
                    FindLevel(node.RightChild);
                }
            }
                //if left and right are null retuen the Level + 1
                return Level + 1; 
           
            
            
        }
    }
}
