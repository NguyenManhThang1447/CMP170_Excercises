using System;
using System.IO;

namespace List_All_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string ListFile = @"C:\Users\Admin\Documents";

            string[] Files = Directory.GetFiles(ListFile);

            foreach (var File in Files)
            {
                Console.WriteLine(File);
            }

            Console.ReadKey();
        }
    }
}