namespace iftry
{
    public class Logic
    {
        public static bool CanFit(double a, double b, double c, double d)
        {
            return (a <= c && b <= d) || (a <= d && b <= c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            bool canPut = Logic.CanFit(a, b, c, d);
            if (canPut)
                Console.WriteLine("Можно");
            else
                Console.WriteLine("Нельзя");
        }
    }
}
