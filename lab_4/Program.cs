using System;

namespace lab_4
{
    /*
     * Спроектируйте класс, наполните его требуемой функциональностью, проде-монстрируйте работоспособность класса
     *
     *
     * Класс «Точка в пространстве». Реализовать ввод и вывод полей данных, вычисление расстояния до введенной
     * пользователем точки, расстояния от начала координат, а также вывод информации об объекте.
     */
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
        private Double x2 = 0;
        private Double y1 = 0;
        private Double y2 = 0;

        private Double rasst;

        public Dot(double x2, double y2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public double X1
        {
            get => x1;
            set => x1 = value;
        }

        public double Y1
        {
            get => y1;
            set => y1 = value;
        }

        public double Rasst
        {
            get => f();

            set => rasst = value;
        }

        private double f()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}