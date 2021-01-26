using System;
using System.Collections;
using System.Collections.Generic;
using Utils.Entity;
using Utils.Menu;

namespace Utils.Helpers
{
    /// <summary>
    /// Класс помощник по созданию и выводу коллекции в консоль
    /// </summary>
    public static class CollectionHelper
    {
        /// <summary>
        /// Создание объекта случайного типа с случайными данными
        /// </summary>
        /// <returns></returns>
        public static object GenerateNewRandomObject()
        {
            object obj = null;

            int number = new Random().Next(0, 3);

            switch (number)
            {
                // int
                case 0:
                    {
                        obj = new Random().Next(-1000, 5000);
                        break;
                    }
                // double
                case 1:
                    {
                        obj = new Random().Next(-1000000, 50000000) + new Random().NextDouble();
                        break;
                    }
                // string
                case 2:
                    {
                        obj = $"Строка {new Random().Next(0, 100000)}";
                        break;
                    }
                // объект
                case 3:
                    {
                        obj = new MenuItem($"Меню {new Random().Next(0, 100000)}")
                        {
                            MenuPosition = new Random().Next(0, 100)
                        };
                        break;
                    }
            }

            return obj;
        }

        /// <summary>
        /// Создание коллекции со случайными данными
        /// </summary>
        /// <param name="count">Размерность коллекции</param>
        /// <returns></returns>
        public static ArrayList GenerateRandomArray(int count)
        {
            var array = new ArrayList();

            for (int i = 0; i < count; i++)
            {
                array.Add(GenerateNewRandomObject());
            }

            return array;
        }

        /// <summary>
        /// Создание словаря со случайными данными
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="count">Размерность словаря</param>
        /// <returns></returns>
        public static IDictionary GenerateRandomDictionary(this IDictionary dictionary, int count)
        {
            for (int i = 0; i < count; i++)
            {
                dictionary.Add(GenerateNewRandomObject(), GenerateNewRandomObject());
            }

            return dictionary;
        }

        /// <summary>
        /// Вывод коллекции в цикле foreach
        /// </summary>
        /// <param name="list">Коллекция элементов</param>
        /// <param name="message">Сообщение какая коллекция будет выводиться</param>
        public static void Print(this IEnumerable list, string message)
        {
            Console.WriteLine(message);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
        }

        /// <summary>
        /// Вывод коллекции в цикле foreach
        /// </summary>
        /// <param name="dict">Список элементов ключ-значение</param>
        /// <param name="message">Сообщение какая коллекция будет выводиться</param>
        public static void Print(this IDictionary dict, string message)
        {
            Console.WriteLine(message);
            foreach (DictionaryEntry item in dict)
            {
                Console.WriteLine($"Ключ - {item.Key} | Значение - {item.Value}");
            }

            Console.WriteLine("--------------------");
        }

        /// <summary>
        /// Вывод коллекции в цикле foreach
        /// </summary>
        /// <param name="dict">Список элементов ключ-значение</param>
        /// <param name="message">Сообщение какая коллекция будет выводиться</param>
        public static void Print(this Dictionary<IPerson, IPhone> dict, string message)
        {
            Console.WriteLine(message);
            foreach (var item in dict)
            {
                Console.WriteLine($"Ключ - {item.Key.GetInfo()} | Значение - {item.Value.GetInfo()}");
            }

            Console.WriteLine("--------------------");
        }
    }
}
