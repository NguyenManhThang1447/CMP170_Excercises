using System;
using System.IO;

namespace List_All_Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive name: {0}", drive.Name);
            }
            Console.ReadLine();
        }
    }
}
