using System;
using System.IO;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            RECsearch();
        }

        static void RECsearch()
        {
            Console.WriteLine("Укажите путь");
            string directory = Console.ReadLine();
            
            if (Directory.Exists(directory))
            {
                Console.WriteLine("Укажите название файла");
                string name = Console.ReadLine();
                rec(new DirectoryInfo(directory), name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Такого пути не существует");
                RECsearch();
            }
        }

        static void rec(DirectoryInfo dir, string name)
        {
            foreach (var file in dir.GetFiles(name))
            {
                Console.WriteLine(file);
            }
            foreach (var newDIR in dir.GetDirectories())
            {
                rec(newDIR, name);
            } 
        }

        //static void search(string inf, string file)
        //{
        //    if (Directory.Exists(inf))
        //    {
        //        string[] testing = Directory.GetFiles(inf, file, SearchOption.AllDirectories);
        //        foreach (string s in testing)
        //        {
        //            Console.WriteLine(s);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Такого пути не существует");
        //    }
        //}
    }
}
