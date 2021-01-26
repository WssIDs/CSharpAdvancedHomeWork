using System;
using System.Collections;
using Utils.Helpers;
using Utils.Menu;

namespace HomeWork1.Collections
{
    public static class CollectionListExample
    {
        /// <summary>
        /// Запуска примера работы с коллекцией ArrayList
        /// </summary>
        public static void RunArrayList()
        {
            var arrayList = new ArrayList {1, 2, 3, 43};

            arrayList.Print("Вывод ArrayList");

            // Добавление строки
            arrayList.Add("Test");
            // Добавление типа double
            arrayList.Add(0.35);


            var menuItem = new MenuItem("Меню1")
            {
                MenuPosition = 0
            };

            // Добавление объекта
            arrayList.Add(menuItem);

            arrayList.Print("Вывод ArrayList после добавления");

            // удаление объекта
            arrayList.Remove(menuItem);

            // Удаление по индексу
            arrayList.RemoveAt(1);

            arrayList.Print("Вывод ArrayList после удаления");

            Console.WriteLine($"Элемент с индексом 4 - {arrayList[4]}");
        }

        /// <summary>
        /// Запуска примера работы со Стеком
        /// </summary>
        public static void RunStack()
        {
            var stack = new Stack();

            stack.Push("Иванов Иван");
            stack.Push("Петров Петр");
            stack.Push("Васильев Василий");
            stack.Push("Васнецов Анатолий");

            stack.Print("Вывод Stack");

            // Положить число в стек
            stack.Push(10);

            var menuItem = new MenuItem("Меню1")
            {
                MenuPosition = 0
            };

            //  Положить объект в стек
            stack.Push(menuItem);

            stack.Print("Вывод Stack после добавления");

            // Изъять из стека последний добавленный объект
            var poppedObj = stack.Pop();

            Console.WriteLine($"Последний изъятый объект из стека - {poppedObj}");

            stack.Print("Вывод Stack после изъятия");

            Console.WriteLine($"Количество элементов в стеке (до очистки) - {stack.Count}");

            stack.Clear();

            stack.Print("Вывод Stack после вызова Clear()");
            Console.WriteLine($"Количество элементов в стеке (после очистки) - {stack.Count}");
        }

        /// <summary>
        /// Запуска примера работы с Очередью
        /// </summary>
        public static void RunQueue()
        {
            var queue = new Queue(CollectionHelper.GenerateRandomArray(new Random().Next(1, 20)));

            queue.Print("Вывод Queue");

            // Положить число в стек
            queue.Enqueue(10);

            var menuItem = new MenuItem("Меню5")
            {
                MenuPosition = 10
            };

            //  Положить объект в стек
            queue.Enqueue(menuItem);

            queue.Print("Вывод Queue после добавления");

            // Получить объект в очереди без изъятия
            var pickedObj = queue.Peek();
            Console.WriteLine($"Первый объект в очереди - {pickedObj}");

            // Изъять из стека первый добавленный объект
            var dequeuedObj = queue.Dequeue();

            Console.WriteLine($"Изъятый объект из очереди - {dequeuedObj}");

            queue.Print("Вывод Queue после изъятия");
        }

        /// <summary>
        /// Запуска примера работы с Хэш-таблицей
        /// </summary>
        public static void RunHashTable()
        {
            var hashTable = new Hashtable().GenerateRandomDictionary(10);

            hashTable.Print("Вывод Hashtable");

            // Положить число в стек
            hashTable.Add(10, "Какое-то значение");

            var menuItem = new MenuItem("Меню5")
            {
                MenuPosition = 10
            };

            //  Положить объект в хэш таблицу
            hashTable.Add(menuItem, 1);

            hashTable.Print("Вывод Hashtable после добавления");

            //  Положить объект в стек
            hashTable.Remove(menuItem);

            hashTable.Print("Вывод Hashtable после удаления");
        }
    }
}
