namespace DataStructures.Queue
{
    public class Enqueue
    {
        public static void EnqueueRequest(Queue<string> queue, string url)
        {
            Console.WriteLine($"Request Received : {url}");
            queue.Enqueue(url);
        }

    }
}
