using System;

namespace Lab_2
{
    internal class Program
    {
        public static double z = 0, Y = 2, X = 2, n = 2, a = 1, b = 1, i = 2;

        public static void Main(string[] args)
        {
            String s = "";
            
            switch (readLine())
            {
                case 1:
                    for (i = 2; i <= 5; i++)
                    {
                        formula();
                    }
                    break;
                case 2:
                    while (i <= 5)
                    {
                        formula();
                        i++;
                    }
                    break;
                case 3:
                    do
                    {
                        formula();
                        i++;
                    } while (i <= 5);

                    break;
            }


            Console.WriteLine(z);
        }

        private static void formula()
        {
            if (i % 2 == 0)
            {
                b = n;
            }
            else
            {
                a = n;
            }

            z += ((Math.Pow(X, a) * Math.Pow(Y, b)) / n) * Math.Pow(-1, i);
            n += 2;
        }

        private static int readLine()
        {
            Console.WriteLine("Введите 1 для for");
            Console.WriteLine("Введите 2 для while");
            Console.WriteLine("Введите 3 для do while");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}