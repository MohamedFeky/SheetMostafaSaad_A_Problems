namespace BearAndBigBrother
{
    internal class Program
    {
        public static int CountWeight(int a, int b)
        {
            int count = 0;
            if (1 <= a && a <= b && b <= 10)
            {
                while (a <= b)
                {
                    a = a * 3;
                    b = b * 2;
                    count++;
                }
              
            }
            return count;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine(CountWeight(a,b));
        }
    }
}
