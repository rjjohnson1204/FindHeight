using FindHeight.Classes;
using System;


namespace FindHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //building of the tree
            Node root = new Node(0);
            root.LeftChild = new Node(0);
            root.RightChild = new Node(0);
            root.LeftChild.LeftChild = new Node(0);
            root.LeftChild.LeftChild.LeftChild = new Node(0);

            // outputs the max tree height
            Console.WriteLine(FindHeight(Max));
        }

        //traverses the tree to
        public int FindHeight(Tree node)
        {
            // number of traversals
            int Counter = 0;
            // max height so far
            int Max = 0;

            //counter value will replace max value if it is a larger value
            if (Counter < Max)
            {
                Max = Counter;
            
            }
            
            //checks to see if root is null
            if (node.Root = null)
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
                    FindHeight(node.LeftChild);
                }

                //checks to see if right child equal null
                if (node.RightChild != null)
                {
                    //if not null run the method again
                    FindHeight(node.RightChild);
                }
            }
                //if left and right are null retuen the max + 1
           
            
                return Max + 1;
            
        }
    }
}
