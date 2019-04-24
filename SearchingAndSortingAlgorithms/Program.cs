using System;

namespace SearchingAndSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            //int searchValue = Convert.ToInt32(Console.ReadLine());
            //int index = LinearSearch.Find(arr, searchValue);
            //int index = BinarySearch.Find(arr, searchValue);
            //int index = BinarySearch.RecursiveFind(arr, searchValue, 0, arr.Length - 1);
            //Console.WriteLine(index);

            //int[] sortedArr = BubbleSort.Sort(arr);
            //int[] sortedArr = BubbleSort.ModifiedBubbleSort(arr);
            //int[] sortedArr = InsertionSort.Sort(arr);
            //int[] sortedArr = SelectionSort.Sort(arr);
            //int[] sortedArr = MergeSort.Sort(ref arr, 0, arr.Length - 1);
            int[] sortedArr = QuickSort.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(' ', sortedArr));

            Console.ReadLine();
        }
    }
}
