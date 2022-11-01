namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            text1 = System.Text.RegularExpressions.Regex.Replace(text1, @"\s+", " ");
            text1 = text1.Trim();
            Console.WriteLine(text1);
        }
    }
}