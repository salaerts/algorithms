using Xunit;

namespace Algorithms.Tests
{
    public class MergeSortFixture
    {
        [Fact]
        public void SortsUnsortedArrayWithEvenNumberOfItems()
        {
            var input = new[] {7, 4, 1, 8, 5, 2, 9, 6, 3, 0};
            var output = MergeSort.Sort(input);

            Assert.Equal(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, output);
        }

        [Fact]
        public void CanHandleEmptyArray()
        {
            var input = new int[0];
            var output = MergeSort.Sort(input);

            Assert.Equal(new int[0], output);
        }

        [Fact]
        public void CanHandleSingleItemArray()
        {
            var input = new[] { 2 };
            MergeSort.Sort(input);

            Assert.Equal(new[] { 2 }, input);
        }
    }
}