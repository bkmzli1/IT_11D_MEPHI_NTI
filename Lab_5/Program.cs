using System;

namespace Lab_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dot = new Dot(readLine("x2"), readLine("y2"));
            Console.WriteLine(dot.Rasst);
        }

        private static double readLine(String s)
        {
            Console.Write("Введите {0}:", s);
            return Convert.ToDouble(Console.ReadLine());
        }
    }

    class Dot
    {
        private Double x1 = 0;
        private Double y1 = 0;

        private Double rasst;

        public Dot(double x2, double y2)
        {
            rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public Dot(int x2, int y2)
        {
            rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public Dot(long x2, long y2)
        {
            rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public Dot(float x2, float y2)
        {
            rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public Dot(String x2, String y2)
        {
            rasst = Math.Sqrt(Math.Pow(Convert.ToDouble(x2) - x1, 2) + Math.Pow(Convert.ToDouble(y2) - y1, 2));
        }

        public double Rasst => rasst;
    }
}