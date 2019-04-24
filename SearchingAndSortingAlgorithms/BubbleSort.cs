namespace SearchingAndSortingAlgorithms
{
    public class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] ModifiedBubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool swapped = false;
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            return arr;
        }
    }
}
