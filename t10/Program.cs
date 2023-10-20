using System;
using System.Collections;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace t10
{
    public class FileReader
    {
        private string path;
        public FileReader(string n) 
        { 
            path = n; 
        }

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
        private string _line;
        private string _wordToSearch;

        public Finder(string line, string wordToSearch) 
        { 
            _line = line;
            _wordToSearch = wordToSearch; 
        }

        public void Find(string _line, string _wordToSearch)
        {
            if (_line.IndexOf(_wordToSearch) != -1)
                Console.WriteLine(_line);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new FileReader(GetStr("Введите название файла вместе с путем: "));
            string word = GetStr("Введите слово, которое будем искать: ");
            var finder = new Finder("","");
            
            foreach (var n in fileReader)
            {
                finder.Find(n, word);
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