using Xunit;

namespace Algorithms.Tests
{
    public class MergeSortFixture
    {
        [Fact]
        public void SortsUnsortedArray()
        {
            var input = new[] {7, 4, 1, 8, 5, 2, 9, 6, 3, 0};
            MergeSort.Sort(input);

            Assert.Equal(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, input);
        }
    }
}