namespace _01._Stack_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseString = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverseString.Push(input[i]);
                
            }

            foreach (char c in reverseString)
            { 
                Console.Write(c); 
            }
        }
    }
}
