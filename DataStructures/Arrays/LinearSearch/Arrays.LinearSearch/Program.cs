namespace Arrays.LinearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 10, 40, 5, 7 };
            int taget = 5;
            int result = LinearSearchExample.LinearSearch(array, taget);

            if (result != -1)
                Console.WriteLine("Element is present at index : " + result);

            else
                Console.WriteLine("Element is not present in array");
        }

    }
}
