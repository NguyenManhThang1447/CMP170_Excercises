using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input X = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Input Y = ");
            float y = float.Parse(Console.ReadLine());
            Console.Write("X + Y = ");
            Console.WriteLine(x + y);
            Console.Write("X - Y = ");
            Console.WriteLine(x - y);
            Console.Write("X * Y = ");
            Console.WriteLine(x * y);
            Console.Write("X / Y = ");
            Console.WriteLine(x / y);
        }
    }
}
