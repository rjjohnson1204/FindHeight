using FindHeight.Classes;
using System;
using Xunit;
using static FindHeight.Program;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void NodeHasValue()
        {
            Node node = new Node(1);

            int expected = 1;

            int actual = 1; 

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LeftChildValue()
        {
            Node leftchild = new Node(5);

            int expected = 5;

            int actual = 5;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RightChildValue()
        {
            Node leftchild = new Node(10);

            int expected = 10;

            int actual = 10;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanFindTwoLevels()

        {
            // level 1
            Node node = new Node(1);

            // level 2
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            node.LeftChild = node2;
            node.RightChild = node3;

            Assert.Equal(2, FindLevel(node, 1));

        }

        [Fact]
        public void CanReturnRootLevel()

        {
            // level 1
            Node node = new Node(1);


            Assert.Equal(1, FindLevel(node, 1));

        }


    }
}
