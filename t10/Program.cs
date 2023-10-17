using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace t10
{
    public class FileReader
    {
        public string path;

        public string[] FileRead() 
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }
    }

    class Finder
    {
        public string[] lines;
        public string W;

        public void Finders()
        {
            foreach (var item in lines)
            {
                if (item.IndexOf(W) != -1)
                    Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new FileReader();
            var obj2 = new Finder();
            obj.path = GetStr("Введите название файла вместе с путем: ");
            obj2.W = GetStr("Введите слово, которое будем искать: ");
            obj2.lines = obj.FileRead();
            obj2.Finders();
        }

        private static string GetStr(string txt)
        {
            Console.Write(txt);
            string path = Console.ReadLine();
            return path;
        }
    }
}