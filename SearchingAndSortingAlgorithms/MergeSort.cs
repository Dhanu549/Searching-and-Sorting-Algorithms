namespace SearchingAndSortingAlgorithms
{
    public class MergeSort
    {
        public static int[] Sort(ref int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sort(ref arr, l, m);
                Sort(ref arr, m + 1, r);
                Merge(ref arr, l, r, m);
            }

            return arr;
        }

        public static void Merge(ref int[] arr, int l, int r, int m)
        {
            int n1 = m - l + 1, n2 = r - m;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            int i, j, k;

            for (i = 0; i < n1; i++)
                leftArr[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                rightArr[j] = arr[m + 1 + j];

            i = 0;
            j = 0;
            k = l;

            while(i<n1 && j<n2)
            {
                if (leftArr[i] <= rightArr[j])
                    arr[k++] = leftArr[i++];
                else
                    arr[k++] = rightArr[j++];
            }
            while (i < n1)
                arr[k++] = leftArr[i++];
            while (j < n2)
                arr[k++] = rightArr[j++];            
        }
    }
}
