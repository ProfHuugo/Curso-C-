using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string path = @"D:\Devv\file1.txt";
        //    FileStream? fs = null;
        //    StreamReader? sr = null;

        //    try
        //    {
        //         fs = new FileStream(path, FileMode.Open);
        //         sr = new StreamReader(fs);
        //         string? line = sr.ReadLine();
        //         Console.WriteLine(line);
        //    }
        //     catch (IOException e)
        //     {
        //         Console.WriteLine("An error ocurred");
        //         Console.WriteLine(e.Message);
        //     }
        //     finally
        //     {
        //         if (sr != null) sr.Close();
        //         if (fs != null) fs.Close();
        //     }



           string path = @"D:\Devv\file1.txt";
          
           StreamReader? sr = null;

           try
           {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    Console.WriteLine(line);
                }
           }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }
}