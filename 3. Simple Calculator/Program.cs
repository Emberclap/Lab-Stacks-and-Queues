using System.Security.Cryptography.X509Certificates;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] reversed = input.Split()
                .Reverse()
                .ToArray();
            
            int result = 0;
            Stack<string> stack = new Stack<string>();
            foreach (string s in reversed)
            {
                stack.Push(s);
            }
            result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());
                if (operation == "-")
                {
                    result -= number;
                }
                else if (operation == "+")
                {
                    result += number;
                }
            }
            Console.WriteLine(result);
        }
    }
}