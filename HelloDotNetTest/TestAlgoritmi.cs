using FluentAssertions;
using it.Finsa.HelloDotNetCore.Algorithms;
using System.Collections;
using System.Collections.Generic;
using Xunit;

//using System.Windows.Forms;
//using System.Threading;


//using WinformTimer = System.Windows.Forms.Timer;
//using ThreadingTimer = System.Threading.Timer;

namespace HelloDotNetTest
{


    public class TestDataGenerator : IEnumerable<object[]>
    {
   
        Other o = new Other();
        float[] ff = { 3.6f, 6.7f };
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] {new int[] { 1, 65, 23, 7, 89, 90, 91, 5, 2, 12 }},
            new object[] {new int[] { 54, 4545, 90, 383, 11111, 2083, 4545, 3, 2 }}
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    public class TestDataGeneratorSorted : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] {new int[] { 1, 4, 6, 9, 11, 23, 45, 80 }},
            new object[] {new int[] { 54, 80, 342, 4324, 1234, 3333, 8399, 36524, 1923764}}
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class TestAlgoritmi
    {
       


        [Theory]
        [ClassData(typeof(TestDataGeneratorSorted))]
        public void TestBinarySearch(int[] testInts)
        {
          
            //int[] testInts = { 1, 4, 6, 9, 11, 23, 45, 80 };
            bool found = it.Finsa.HelloDotNetCore.Algorithms.Program.BinarySearch(testInts, 80, 0, testInts.Length - 1);
            Assert.True(found);
            found = Program.BinarySearch(testInts, 79, 0, testInts.Length - 1);
            Assert.False(found);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestBubbleSort(int[] testInts)
        {
          
            testInts.Should().NotBeAscendingInOrder();
            Program.BubbleSort(testInts);
            testInts.Should().BeInAscendingOrder();
          
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestSelectionSort(int[] testInts)
        {
           
            testInts.Should().NotBeAscendingInOrder();
            Program.SelectionSort(testInts);
            testInts.Should().BeInAscendingOrder();
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestInsertionSort(int[] testInts)
        {
    
            testInts.Should().NotBeAscendingInOrder();
            Program.InsertionSort(testInts);
            testInts.Should().BeInAscendingOrder();
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestMergeSort(int[] testInts)
        {
        
            testInts.Should().NotBeAscendingInOrder();
            Program.MergeSort(testInts);
            testInts.Should().BeInAscendingOrder();
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestQuickSort(int[] testInts)
        {
       
            testInts.Should().NotBeAscendingInOrder();
            Program.QuickSort(testInts);
            testInts.Should().BeInAscendingOrder();
        }

        [Fact]
        public void TestFindCoupleWithSum()
        {
            int[] testInts = { 1, 4, 6, 9, 11, 23, 45, 80 };
            const int existingTargetSum = 89;
            bool found = Program.FindCoupleWithSum(existingTargetSum, testInts);
            found.Should().BeTrue();
            const int nonExistingTargetSum = 28;
            found = Program.FindCoupleWithSum(nonExistingTargetSum, testInts);
            found.Should().BeFalse();

        }
    }
}
