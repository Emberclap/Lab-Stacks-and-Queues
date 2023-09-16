namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> players = new Queue<string>();
            int tossCount = 0;

            foreach (string child in children)
            {
                players.Enqueue(child);
            }
            while (players.Count > 1)
            {
                tossCount++;
                string currentPlayer = players.Dequeue();
                if (tossCount == n)
                {
                    Console.WriteLine($"Removed {currentPlayer}");
                    tossCount = 0;
                }
                else
                {
                    players.Enqueue (currentPlayer);
                }
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}