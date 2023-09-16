namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expresions = Console.ReadLine();

            Stack<int> openingBrackets = new Stack<int>();
            for (int i = 0; i < expresions.Length; i++)
            {
                if (expresions[i] == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (expresions[i] == ')')
                {
                    int openingBracketIndex = openingBrackets.Pop();
                    Console.WriteLine(expresions.Substring(openingBracketIndex, i - openingBracketIndex + 1));
                }
            }
        }
    }
}