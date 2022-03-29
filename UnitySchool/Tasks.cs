﻿using System;

namespace UnitySchool
{
    class Tasks
    {
        static void Main(string[] args)
        {
            //Даны две переменные.
            //Поменять местами значения двух переменных.
            //Вывести на экран значения переменных до перестановки и после.
            //К примеру, есть две переменные имя и фамилия, они сразу инициализированные,
            //но данные не верные, перепутанные. Вот эти данные и надо поменять местами через код.
            Console.WriteLine("Task 5");
            string surname = "Natasha ",
                   name = "Romanoff ";

            Console.WriteLine($"Name: {name}\nSurname: {surname}");

            (surname, name) = (name, surname);

            Console.WriteLine($"Name: {name}\nSurname: {surname}");
            //Если надо было просто изменить вывод, то
            //Console.WriteLine($"Name: {surname}\nSurname: {name}");
            Console.WriteLine(".................................");

            //На экране, в специальной зоне, выводятся картинки, по 3 в ряд.
            //Всего у пользователя в альбоме 52 картинки.
            //Код должен вывести, сколько полностью заполненных рядов можно будет вывести,
            //и сколько картинок будет сверх меры.
            //В качестве решения ожидаются объявленные переменные с необходимыми значениями и,
            //основываясь на значениях переменных, вывод необходимых данных.
            Console.WriteLine("Task 6");
            int myPicture = 52,
                restriction = 3;

            Console.WriteLine($"Всего запонленных рядов: {myPicture / restriction} \nОставшихся картинок: {myPicture % restriction}");

            //        Легенда:
            //Вы приходите в магазин и хотите купить за своё золото кристаллы.
            //В вашем кошельке есть какое - то количество золота, продавец спрашивает у вас,
            //сколько кристаллов вы хотите купить? После сделки у вас остаётся какое - то количество золота
            //и появляется какое - то количество кристаллов.
            //        Формально:
            //При старте программы пользователь вводит начальное количество золота.
            //Потом ему предлагается купить какое - то количество кристаллов по цене N(задать в программе самому).
            //Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.
            //Проверять на то, что у игрока достаточно денег не нужно.
            Console.WriteLine(".................................");
            Console.WriteLine("Task 7");
            Console.WriteLine("Введите количество золота");

            int goldenCoins = Convert.ToInt32(Console.ReadLine());
            int priceCrystal = 20;

            Console.WriteLine("Один кристал стоит {0} монет", priceCrystal);
            Console.WriteLine("Сколько кристалов желаете приобрести?");

            int myCrystals = Convert.ToInt32(Console.ReadLine());

            if (myCrystals * priceCrystal <= goldenCoins)
            {
                for (int i = 0; i < myCrystals; i++)
                {
                    goldenCoins -= priceCrystal;
                }
                Console.WriteLine($"В вашем кошельке: {goldenCoins} монет и кристалов {myCrystals}");
            }
            else Console.WriteLine($"Средств недостаточно \nВ вашем кошельке: {goldenCoins} монет");


            //Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.
            //  Формально:
            //Пользователь вводит кол - во людей в очереди.
            //Фиксированное время приема одного человека всегда равно 10 минутам.
            //Пример ввода: Введите кол-во старушек: 14
            //Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."
            Console.WriteLine(".................................");
            Console.WriteLine("Task 8");
            Console.WriteLine("Введите кол-во старушек:");
            int peopleInLine = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Время ожидания {peopleInLine * 10 / 60} часа {peopleInLine * 10 % 60} минут");

            Console.ReadKey();
        }
    }
}
