using System;
using Xunit;

namespace SOL.Core.Tests
{
    public class CalculateTests
    {
        [Fact]
        public void TestAdd1()
        {
            Assert.Equal(2, Calculate.Add(1, 1));
        }
    }
}
