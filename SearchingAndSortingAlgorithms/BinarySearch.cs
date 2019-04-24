namespace SearchingAndSortingAlgorithms
{
    public class BinarySearch
    {
        public static int Find(int[] arr, int data)
        {
            int l = 0, r = arr.Length - 1;            

            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == data)
                    return m;
                else if (arr[m] < data)
                    l = m + 1;
                else
                    r = m - 1;
            }

            return -1;
        }

        public static int RecursiveFind(int[] arr, int data, int l, int r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] == data)
                return m;
            else if (arr[m] < data)
                return RecursiveFind(arr, data, m + 1, r);
            else
                return RecursiveFind(arr, data, l, m - 1);
        }
    }
}
