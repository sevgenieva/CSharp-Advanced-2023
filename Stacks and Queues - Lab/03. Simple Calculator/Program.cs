namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList(); ;
           Stack<string> info = new Stack<string>(list);
            Stack<string> reverse = new Stack<string>();

            foreach (var line in info)
            {
                reverse.Push(line);
            }
            
            int sum = 0;
            int number = 0;
            string info1 = string.Empty;

            while (reverse.Count > 0)
            {
                info1 = reverse.Pop();

                if (info1 == "+")
                {
                    number = int.Parse(reverse.Pop());
                    sum += number;
                }
                else if (info1 == "-")
                {
                    number = int.Parse(reverse.Pop());
                    sum -= number;
                }
                else
                {
                    sum = int.Parse(info1);
                }
                


            }

            Console.WriteLine(sum);
        }
    }
}
