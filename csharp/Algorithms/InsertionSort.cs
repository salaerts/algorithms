namespace Algorithms
{
    /// <summary>
    /// Implementation of the insertion sort algorithm.
    /// Insertion sort iterates, consuming one input element 
    /// each repetition, and growing a sorted output list. 
    /// Each iteration, insertion sort removes one element 
    /// from the input data, finds the location it belongs within the sorted list, 
    /// and inserts it there. It repeats until no input elements remain.
    /// 
    /// Worst case running time: O(n²)
    ///
    /// Advantages:
    /// - Simple implementation
    /// - Efficient for (quite) small data sets
    /// - Adaptive (i.e., efficient) for data sets that are already substantially sorted: 
    ///   the time complexity is O(n + d), where d is the number of inversions
    /// - More efficient in practice than most other simple quadratic (i.e., O(n2)) algorithms 
    ///   such as selection sort or bubble sort; the best case (nearly sorted input) is O(n)
    /// - Stable; i.e., does not change the relative order of elements with equal keys
    /// - In-place; i.e., only requires a constant amount O(1) of additional memory space
    /// - Online; i.e., can sort a list as it receives it
    /// </summary>
    public class InsertionSort
    {
        public static void Sort(int[] input, int size)
        {
            for (var i = 1; i < size; i++)
            {
                var key = input[i];
                var j = i;
                while (j > 0 && input[j-1] > key)
                {
                    input[j] = input[j-1];
                    j = j - 1;
                }

                input[j] = key;
            }
        }
    }
}
