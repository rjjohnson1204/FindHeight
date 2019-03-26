using FindHeight.Classes;
using System;
using Xunit;

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
            Node leftchild = new Node(5);

            int expected = 10;

            int actual = 10;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TreeLevel()
        {


        }


    }
}
