using System;
using System.Collections;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Linq;

namespace t10
{
    public class FileReader
    {
        public string path;

        public IEnumerator<string> GetEnumerator()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }

    class Finder
    {
        public string lines;
        public string W;

        public void Finders()
        {
            if (lines.IndexOf(W) != -1)
                Console.WriteLine(lines);
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
            

            foreach (var n in obj)
            {
                obj2.lines = n;
                obj2.Finders();
            }
        }

        private static string GetStr(string txt)
        {
            Console.Write(txt);
            string path = Console.ReadLine();
            return path;
        }
    }
}