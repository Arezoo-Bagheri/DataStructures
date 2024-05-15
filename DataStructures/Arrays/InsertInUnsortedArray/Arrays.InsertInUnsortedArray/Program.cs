namespace Arrays.InsertInUnsortedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            array[0] = 12;
            array[1] = 16;
            array[2] = 20;
            array[3] = 40;
            array[4] = 50;
            array[5] = 70;

            int capacity = 20;
            int n = 6;
            int i, key = 26;

            Console.Write("Before Insertion: ");

            for (i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();

            n = UnsortedArrayExample.InsertUnsorted(array, n, key, capacity);


            Console.Write("After Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(array[i] + " ");

        }
    }
}
