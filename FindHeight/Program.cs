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
            node.LeftChild = new Node(1);
            node.RightChild = new Node(2);
            node.RightChild.LeftChild = new Node(8);
            node.RightChild.RightChild = new Node(9);
            node.RightChild.RightChild.LeftChild = new Node(11);
            node.RightChild.RightChild.LeftChild.LeftChild = new Node(22);
            //node.RightChild.RightChild.LeftChild.LeftChild.LeftChild = new Node(33);
            //node.RightChild.RightChild.LeftChild.LeftChild.LeftChild.RightChild = new Node(44);
            //node.RightChild.RightChild.LeftChild.LeftChild.LeftChild.RightChild.LeftChild = new Node(55);
            //node.RightChild.RightChild.RightChild = new Node(99);
            //node.RightChild.RightChild.RightChild.RightChild = new Node(101);
            //node.LeftChild.LeftChild = new Node(3);
            //node.LeftChild.LeftChild.LeftChild = new Node(4);

            // writes the number of levels of the tree
            Console.WriteLine(FindLevel(node, 0));
             Console.ReadLine();
        }

        public static int FindLevel(Node node, int Count)
        {
            // number of traversals
            int Counter = Count + 1;
            // Level Level so far
            //int Max = 0;
            //counter value will replace Level value if it is a larger value
            //if (Counter > Max)
            //{
            //    Max = Counter;
            //}

            //checks to see if root is null
            Count++;

            if (node == null)
            {
                return 0;
            }
            // adds to counter when hit
            //runs until node equals null
            //int left = (FindLevel(node.LeftChild, Counter +1));
            //int right = (FindLevel(node.RightChild, Counter +1));

            // check to see if left child equals null
            if (node.LeftChild != null)
            {
                // if not null run the method again
                Counter = FindLevel(node.LeftChild, Count ++);
            }

            //checks to see if right child equal null
            if (node.RightChild != null)
            {
                //if not null run the method again
               Counter =  FindLevel(node.RightChild, Count ++);
            }
                            
             //returns max
            //Count = Counter;
             return Counter;

        }
    }
}

        //public static int FindLevel(Node node, int Counter)
        //{


        //    if (node == null)
        //    {
        //        return 0;
        //    }


        //    //if (node.LeftChild != null)
        //    //{
        //    //    FindLevel(node.LeftChild, Counter);
        //    //}

        //    //if(node.RightChild != null)
        //    //{
        //    //    FindLevel(node.RightChild, Counter);
        //    //}

        //    int leftHeight = FindLevel(node.LeftChild, +1);
        //    int rightHeight = FindLevel(node.RightChild, +1);

        //    if (leftHeight > rightHeight) return leftHeight + 1; 
        //    return rightHeight + 1;



    
    

