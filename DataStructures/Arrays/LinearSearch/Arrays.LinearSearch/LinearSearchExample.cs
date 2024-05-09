namespace Arrays.LinearSearch
{
    public class LinearSearchExample
    {
        public static int LinearSearch(int[] arra, int target)
        {
            for (int i = 0; i < arra.Length; i++)
            {
                if (arra[i] == target)
                    return i;
            }
            return -1;
        }

    }
}
