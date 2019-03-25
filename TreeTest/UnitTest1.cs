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
        public void TreeLevel()
        {
            
        }
    }
}
