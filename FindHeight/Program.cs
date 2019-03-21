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
            Node root = new Node(0);
            root.LeftChild = new Node(1);
            root.RightChild = new Node(2);
            root.RightChild.LeftChild = new Node(8);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(11);
            root.RightChild.RightChild.LeftChild.LeftChild = new Node(22);
            root.RightChild.RightChild.LeftChild.LeftChild.LeftChild = new Node(33);
            root.RightChild.RightChild.LeftChild.LeftChild.LeftChild.RightChild = new Node(44);
            root.RightChild.RightChild.LeftChild.LeftChild.LeftChild.RightChild.LeftChild = new Node(55);
            root.RightChild.RightChild.RightChild = new Node(99);
            root.RightChild.RightChild.RightChild.RightChild = new Node(101);
            root.LeftChild.LeftChild = new Node(3);
            root.LeftChild.LeftChild.LeftChild = new Node(4);

            // writes the numer of levels of the tree
            Console.WriteLine(FindLevel(root));
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
