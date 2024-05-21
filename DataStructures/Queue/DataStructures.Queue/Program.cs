namespace DataStructures.Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> requestQueue = new Queue<string>();

            Enqueue.EnqueueRequest(requestQueue, "/home");
            Enqueue.EnqueueRequest(requestQueue, "/about");
            Enqueue.EnqueueRequest(requestQueue, "/contact");

            Dequeue.ProcessRequests(requestQueue).Wait();
        }
    }
}
