using System;
using Xunit;
using HelloDotNet;

namespace HelloDotNetTest
{
    public class TestAlgoritmi
    {
        [Fact]
        public void TestBinarySearch()
        {
            int[] testInts = {1,4,6,9,11,23,45,80};
            bool found = Program.BinarySearch(testInts, 80, 0, testInts.Length - 1);
            Assert.True(found);
            found = Program.BinarySearch(testInts, 79, 0, testInts.Length - 1);
            Assert.False(found);
        }
    }
}
