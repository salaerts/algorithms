using Xunit;

namespace Algorithms.Tests
{
    public class InsertionSortFixture
    {
        [Fact]
        public void SortsUnsortedArrayInPlace()
        {
            var input = new[] { 7, 4, 1, 8, 5, 2, 9, 6, 3, 0 };
            InsertionSort.Sort(input, input.Length);

            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }

        [Fact]
        public void SortsReverseSortedArrayInPlace()
        {
            var input = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            InsertionSort.Sort(input, input.Length);

            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }

        [Fact]
        public void DoesNotChangeAlreadySortedArray()
        {
            var input = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            InsertionSort.Sort(input, input.Length);

            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }

        [Fact]
        public void CanHandleEmptyArray()
        {
            var input = new int[0];
            InsertionSort.Sort(input, input.Length);

            Assert.Equal(new int[0], input);
        }

        [Fact]
        public void CanHandleSingleItemArray()
        {
            var input = new[] { 1 };
            InsertionSort.Sort(input, input.Length);

            Assert.Equal(new[] { 1 }, input);
        }
    }
}
