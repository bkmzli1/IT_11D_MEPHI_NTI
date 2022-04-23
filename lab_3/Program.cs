using System;
using System.Collections;

namespace lab_3
{
    /*
     *Для инициализации исходной матрицы необходимо использовать генератор случайных чисел. Следует использовать
     * ограничение на генерируемые числа, например, ограничить значения случайно генерируемых чисел величиной 100, 10 и т.д.,
     * чтобы вывод программы был более читабельным. Алгоритм решения должен работать для массивов любой величины, поэтому
     * размер исходного массива запра-шивается у пользователя.
     *
     *
     * Дана исходная матрица размером  M ×N . Вывести исходную матрицу.Вывести средние арифметические для каждой строки
     * и результирующую мат-рицу, в которой все четные элементы заменены на среднее арифметическое в данной строке
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введте высоту");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введте штрену");
            int h = Convert.ToInt32(Console.ReadLine());


            int[,] m = new int[h, w];
            Random random = new Random(245);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    m[i, j] = random.Next(0, 100);
                    Console.Write("{0,2:D} ", m[i, j]);
                }

                Console.WriteLine();
            }

            ArrayList list = new ArrayList();
            for (int i = 0; i < h; i++)
            {
                int s = 0;
                for (int j = 0; j < w; j++)
                {
                    s += m[i, j];
                }

                list.Add(s / w);
                Console.WriteLine("Среднее арф. число строки {0} = {1} ", i + 1, s / w);
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        m[i, j] = (int) list[i];
                    }

                    Console.Write("{0,2:D} ", m[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}