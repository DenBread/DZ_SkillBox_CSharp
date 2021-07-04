using System;

namespace Homework_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Print("Добро пожаловать в записную книжку!");
            
            SelectionPanel();
            

            Console.Read();
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void SelectionPanel()
        {
            

            string[] list = new[] {"a. Добавить работника", "b. Посмотреть список работников", "c. Удалить работника"};

            for (int i = 0; i < list.Length; i++)
            {
                Print(list[i]);
            }

            Console.Write("Ваш выбор: ");

            var choice = Console.ReadKey(true);

            if (choice.KeyChar == 'a')
            {
                Print("A");
                Console.Clear();
                Print("- Добавить работника -");

                Worker worker = new Worker();
                worker.AddInfoWorker();
            }


        }
    }

}
