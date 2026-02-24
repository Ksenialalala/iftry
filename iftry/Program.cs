namespace iftry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2, b = 4, c = 4.5, d = 1.5;
            bool canPut = (a <= c && b <= c) || (a <= d && b <= d);
            if (canPut)
                Console.WriteLine("Можно");
            else
                Console.WriteLine("Нельзя");
        }
    }
}
