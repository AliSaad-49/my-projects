using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, мой друг.Это програма сделано,чтобы подбрать для Вас фильм");
            Console.WriteLine("Как Вас Зовут?");
            string name = Console.ReadLine();
            string text = "Привет," + name;
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
