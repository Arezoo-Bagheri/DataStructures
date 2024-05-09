namespace Arrays.BinarySearch
{
    public class BinarySearchExample
    {
        public static int BinarySearch(int[] array, int x)
        {
            int low = 0, high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x)
                    low = mid + 1;

                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}
