using System;
using System.IO;
namespace ReadFlie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Admin\Documents\Test.txt");
            Console.WriteLine("Content of File");

            foreach (var line in lines)
            {
                Console.Write(line);
            }

            Console.ReadKey();
        }
    }
}
