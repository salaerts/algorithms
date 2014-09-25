namespace Algorithms
{
    /// <summary>
    /// Top-down implementation using lists
    /// (creates new arrays, does not operate in-place on the input array)
    /// 
    /// 1. Divide the unsorted list into n sublists, 
    ///    each containing 1 element (a list of 1 element is considered sorted).
    /// 2. Repeatedly merge sublists to produce new sorted sublists until 
    ///    there is only 1 sublist remaining. This will be the sorted list.
    /// 
    /// Worst-case and average running time: O(n log n)
    /// </summary>
    public class MergeSort
    {
        public static int[] Sort(int[] input)
        {
            // Base case: a list of one or less elements is already sorted
            if (input.Length <= 1)
            {
                return input;
            }

            // recursive case: divide the list into equal-sized sublists
            var middleIndex = input.Length / 2;
            var left = new int[middleIndex];
            var right = new int[input.Length - middleIndex];

            for (var i = 0; i < middleIndex; i++)
            {
                left[i] = input[i];
            }

            for (var i = middleIndex; i < input.Length; i++)
            {
                right[i - middleIndex] = input[i];
            }

            // recursively sort both sublists
            left = Sort(left);
            right = Sort(right);

            // conquer: merge the sorted sublists
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var result = new int[left.Length + right.Length];
            var numLeft = 0;
            var numRight = 0;
            var numResult = 0;

            while (numLeft < left.Length || numRight < right.Length)
            {
                if (numLeft < left.Length && numRight < right.Length)
                {
                    if (left[numLeft] <= right[numRight])
                    {
                        result[numResult] = left[numLeft];
                        numLeft++;
                    }
                    else
                    {
                        result[numResult] = right[numRight];
                        numRight++;
                    }
                }
                else if (numLeft < left.Length)
                {
                    result[numResult] = left[numLeft];
                    numLeft++;
                }
                else if (numRight < right.Length)
                {
                    result[numResult] = right[numRight];
                    numRight++;
                }

                numResult++;
            }

            return result;
        }
    }
}