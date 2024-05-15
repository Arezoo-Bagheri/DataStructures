namespace Arrays.InsertInUnsortedArray
{
    public class UnsortedArrayExample
    {
        public static int InsertUnsorted(int[] array, int n, int key, int capacity)
        {
            if (n >= capacity)
                return n;

            array[n] = key;
            return (n + 1);
        }
    }
}
