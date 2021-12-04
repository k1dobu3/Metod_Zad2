using System;

namespace Metod_Zad2
{
    class Program
    {
        static int Perimetr(int a, int b, int c)
        {
            int Per = a + b + c;
            return Per;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            Console.WriteLine(Perimetr(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

        }
    }
}
