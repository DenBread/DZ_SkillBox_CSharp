using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_02
{
    class Worker
    {
        private string _name; // имя 
        private int _age; // возраст 
        private float _height; // рост
        private int _pointsRussianLanguage; // баллы по русскому языку
        private int _pointsHistory; // баллы по истории
        private int _pointsMath; // баллы по математике

        public Worker(){}

        /// <summary>
        /// Коструктор для ввода данных
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="pointsRL">Баллы по русскому языку</param>
        /// <param name="pointsHistory">Баллы по истории</param>
        /// <param name="pointsMath">Баллы по математике</param>
        public Worker(string name, int age, float height, int pointsRL, int pointsHistory, int pointsMath)
        {
            _name = name;
            _age = age;
            _height = height;
            _pointsRussianLanguage = pointsRL;
            _pointsHistory = pointsHistory;
            _pointsMath = pointsMath;
        }

        public void AddInfoWorker()
        {
            Console.Write("Как вас зовут: ");
            _name = Console.ReadLine();

            Console.Write("Сколько вам лет: ");
            _age = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowInfoWorker()
        {

        }

    }
}
