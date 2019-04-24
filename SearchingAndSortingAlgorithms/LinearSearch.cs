namespace SearchingAndSortingAlgorithms
{
    public class LinearSearch
    {
        public static int Find(int[] arr, int data)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == data)
                    return i;
            }

            return -1;
        }
    }
}
