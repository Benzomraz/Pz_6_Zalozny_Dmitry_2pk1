namespace Pz_6_Zalozny_Dmitry_2pk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше число равно...");
            int n = int.Parse(Console.ReadLine());
            int fib = 1;
            if(n > 0)
            {
                for (int i = 1; i<= n; i++)
                {
                    fib *= i; 
                }
                Console.WriteLine(fib);
            }
            if(n == 0)
            {
                Console.WriteLine(1);
            }
            if(n<0)
            {
                Console.WriteLine(-1);
            }
        }
    }
}