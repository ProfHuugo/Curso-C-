using System;
using System.IO;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Devv";
            

            try
            {
                var folders = Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine();
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\TestUdemy");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}