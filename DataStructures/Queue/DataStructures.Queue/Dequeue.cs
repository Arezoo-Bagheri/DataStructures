namespace DataStructures.Queue
{
    public class Dequeue
    {
        public static async Task ProcessRequests(Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                string request = queue.Dequeue();
                Console.WriteLine($"Processing Request : {request}");

                await Task.Delay(1000);
            }
            Console.WriteLine("All requests have been processed.");
        }
    }
}
