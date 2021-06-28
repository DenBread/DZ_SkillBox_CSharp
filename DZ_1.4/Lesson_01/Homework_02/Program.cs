using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Добро пожаловать в записную книжку!");
            Worker worker = new Worker();

            Console.Read();
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

}
