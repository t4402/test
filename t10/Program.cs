using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace t10
{
    public class FileReader
    {
        public string path;

        public string OpenFileAndFindW()
        {
            //using (StreamReader sr = new StreamReader(path, Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        return sr.ReadLine();
            //    }
            //}
            //return "";

            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                return s;
            }
            return "";
        }
    }

    class Finder
    {
        public string str;
        public string W;

        public void Finders()
        {
            if (str.IndexOf(W) != -1)
                Console.WriteLine(str);
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
            obj2.str = obj.OpenFileAndFindW();
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