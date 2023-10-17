using static System.Net.Mime.MediaTypeNames;

namespace t11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mass = new Stack<string>();
            string str;
            while (true)
            {
                Console.Write("Добавить строку - 1, удалить строку - 2, посмотреть стек - 3, выйти из цикла - 4: ");
                str = Console.ReadLine();
                if (str == "1")
                {
                    Console.Write("Введите строку, которую необходимо добавить: ");
                    str = Console.ReadLine();
                    mass.Push(str);
                }
                else if (str == "2") 
                { 
                    mass.TryPop(out var str2); 
                } 
                else if (str == "3") 
                {
                    foreach (var item in mass)
                    {
                        Console.WriteLine(item);
                    }
                } 
                else if (str == "4") { break; }
            }

        }
    }
}