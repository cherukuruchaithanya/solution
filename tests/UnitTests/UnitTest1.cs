using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
       {
        [Fact]
        public void mutiplytwonumbers()
        {
            var expected = 25;
            var a = 5;
            var b = 5; 
            var actual = mutiply(a, b);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void divitionoftwonumbers()
        {
            var expected = 1;
            var a = 5;
            var b = 5;
            var actual = division(a, b);
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
        [InlineData(-12, -7,-5)]
        [InlineData(0, 0,0)]
        public void ismutiplyworksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, mutiply(n1, n2));
        }
         


        int mutiply(int x, int y)
        {
            return x * y;
        }

        bool division(int x, int y)
        {
            return x/y;
        }
    }
}
