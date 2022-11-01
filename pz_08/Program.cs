namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите мскомое число от 0 до 10");
            int a = 3;
            int b = 4;
            int c = 0;
            int[,] buba = new int[a, b];
            Random r = new Random();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    buba[i, j] = r.Next(0, 10);
                    Console.Write(buba[i,j] + " ");

                }
                Console.WriteLine();

            }
            for( int i = 0; i < a; i++)
            {
                for(int k = 0; k < b; k++)
                {
                    if(buba[i, k] == n )
                    {
                        c += 1;
                    }
                }
            }
            Console.Write("Встречалось " + c + " раз(а)");
        }
    }
}