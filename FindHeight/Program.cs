using System;

namespace FindHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int FindHeight(Tree node)
        {
            int Counter = 0;
            int Max = 0;
            if (Counter > Max)
            {
                Max = Counter;
            }
            
            if (node.Root = null)
            {
                return 0;
            }

            Counter ++; 

            if (node.Root != null)
            {
                if (node.LeftChild != null)
                {
                    FindHeight(node.LeftChild);
                }

                if (node.RightChild != null)
                {
                    FindHeight(node.RightChild);
                }
            }
            else
            {
                return Max + 1;
            }
        }
    }
}
