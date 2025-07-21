namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
           
            while(n > 0)
            {

                    string[] input = Console.ReadLine().Split(' ');
                    int petya = int.Parse(input[0]);
                    int vasya = int.Parse(input[1]);
                    int tonya = int.Parse(input[2]);

                if(petya + vasya +tonya == 2 || petya + vasya + tonya == 3)
                {
                    count++;
                }    
                n--;
            }
            Console.WriteLine(count);
        }
    }
}
