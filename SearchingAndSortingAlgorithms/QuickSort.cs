namespace SearchingAndSortingAlgorithms
{
    public class QuickSort
    {
        public  static int[] Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                Sort(arr, left, pi - 1);
                Sort(arr, pi, right);
            }
            return arr;
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
