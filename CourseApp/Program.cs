using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static double Y(double x, double a, double b)
        {
            return (Math.Sqrt(x) * a) - ((Math.Log(x, 5) * b) / Math.Log10(Math.Abs(x - 1)));
        }

        public static void Main(string[] args)
        {
            double a = 4.1;
            double b = 2.7;
            double xn = 1.2;
            double xk = 5.2;
            double dx = 0.8;

            double[] x = new double[5] { 1.9, 2.15, 2.34, 2.73, 3.16 };

            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {Y(xl, a, b):f3}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {Y(i, a, b):f3}");
            }

            Console.ReadKey();

            Console.WriteLine("Rodina Viktoria");
            Console.ReadLine();
        }
    }
}