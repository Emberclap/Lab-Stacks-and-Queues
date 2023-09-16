namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Queue<string> queue = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    foreach (var name in queue)
                    {
                        Console.WriteLine(name);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}