namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0,10);
                Console.Write(array[i] + " ");
            }
            Console.Write("Элементы массива");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        c += 1;   
                    }
                }

                Console.Write(c + " ");

                c = 0;
                
            }
            Console.Write("Количество их повторений (повторяется в любом положении числа)");
        }
    }
}