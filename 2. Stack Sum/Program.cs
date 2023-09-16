namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            
            string command = Console.ReadLine()
                .ToLower();

            while (command != "end")
            {
                string[] splitted = command.Split(' ');
                if (command.Contains("add"))
                {
                    int first = int.Parse(splitted[1]);
                    int second = int.Parse(splitted[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else if (command.Contains("remove"))
                {
                    int n = int.Parse(splitted[1]);
                    if (stack.Count > n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine()
                .ToLower();
            }
            int sum = 0;
            foreach (int i in stack)
            {
                sum += i;
            }
            Console.WriteLine ($"Sum: {sum}");
        }
    }
}