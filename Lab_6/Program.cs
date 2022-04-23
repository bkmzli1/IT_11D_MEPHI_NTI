using System;
using Lab_6.equipment;
using Lab_6.hardware;

namespace Lab_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CompTex[] compTexes = new CompTex[3];
            compTexes[0] = new Pk(CP.Apple, RAM.Mb1, RAM.Mb4);
            compTexes[1] = new Laptop(CP.Apple, RAM.Mb8, false);
            compTexes[2] = new Server(CP.AMD, RAM.Mb8);
            foreach (var c in compTexes)
            {
                Console.WriteLine(c.toString());
            }
        }
    }
}