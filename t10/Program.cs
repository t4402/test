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
        private string path;
        public FileReader(string n) { path = n; }

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
        private string lines;
        private string W;

        public Finder(string lines, string W) { this.lines = lines; this.W = W; }

        public string Find(string lines, string W)
        {
            if (lines.IndexOf(W) != -1)
                return lines;
            else return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new FileReader(GetStr("Введите название файла вместе с путем: "));
            string W = GetStr("Введите слово, которое будем искать: ");
            var obj2 = new Finder("","");
            

            foreach (var n in obj)
            {
                var text = obj2.Find(n, W);
                if (text != null) 
                {
                    Console.WriteLine(text);
                };
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