using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
       
        [Fact]
        public void mutiplytwonumbers()
        {
            int expected = 25;
            int a = 5;
            int b = 5; 
            int actual = mutiply(a, b);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void divitionoftwonumbers()
        {
            int expected = 1;
            int a = 5;
            int b = 5;
            int actual = division(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,3,3)]
        [InlineData(2,6,3)]
        [InlineData(1,2,2)]
        public void IsdivitionWorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp,division(n1,n2));
        }


        [Theory]
        [InlineData(4,2,2)]
        [InlineData(6, 3,2)]
        [InlineData(0, 0,0)]
        public void ismutiplyworksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, mutiply(n1, n2));
        }
         


        int mutiply(int x, int y)
        {
            return x * y;
        }

        int division(int x, int y)
        {
            return x/y;
        }
    }
}
