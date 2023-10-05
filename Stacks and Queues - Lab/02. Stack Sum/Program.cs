namespace _01._Stack_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while ( command != "end")
            {
                string[] commandInfo = command.Split();

                if (commandInfo[0] == "add")
                {
                    int number = int.Parse(commandInfo[1]);
                    int number1 = int.Parse(commandInfo[2]);
                    stack.Push(number);
                    stack.Push(number1);

                }
                else
                {
                    int number = int.Parse(commandInfo[1]);

                    if (stack.Count >= number)
                    { 
                        for (int i = 0; i < number; i++)
                        {
                            stack.Pop();
                        }
                    }
                   
                   

                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
