using System.IO;
using System.Text;

namespace t10
{
    public class Variables
    {
        public string path;
        public string W;
        private string str;

        public void OpenFileAndFindW()
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    FindWInStr();
                }
            }
        }

        private void FindWInStr()
        {
            if (str.IndexOf(W) != -1)
                PrintStr();
        }

        private void PrintStr()
        {
            Console.WriteLine(str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Variables();
            obj.path = GetStr("Введите название файла вместе с путем: ");
            obj.W = GetStr("Введите слово, которое будем искать: ");

            obj.OpenFileAndFindW();
        }

        private static string GetStr(string txt)
        {
            Console.Write(txt);
            string path = Console.ReadLine();
            return path;
        }


    }
}