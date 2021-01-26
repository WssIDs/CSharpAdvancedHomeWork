using System;
using System.Collections.Generic;
using Utils.Entity;
using Utils.Helpers;

namespace HomeWork1.GenericCollections
{
    public static class GenericCollectionListExample
    {
        /// <summary>
        /// Запуска примера работы со словарем
        /// </summary>
        public static void RunDictionary()
        {
            var dictionary = new Dictionary<IPerson, IPhone>
            {
                {
                    new Employee {Name = "Иван", SurName = "Иванов", Position = "Секретарь"},
                    new Phone {Model = "PXFGH1345", Name = "Philips"}
                },
                {
                    new Employee {Name = "Петр", SurName = "Петров", Position = "Директор"},
                    new Phone {Model = "PXFGH1345", Name = "Philips"}
                },
                {
                    new Student {Name = "Семен", SurName = "Овечкин", Course = 1, Group = "AМ1"},
                    new SmartPhone {Model = "P40 Pro", Name = "Huawei", Os = "Harmony"}
                },
                {
                    new Student {Name = "Ольга", SurName = "Корженова", Course = 1, Group = "AМ1"},
                    new SmartPhone {Model = "10 Max", Name = "IPhone", Os = "IOS"}
                },
                {
                    new Student {Name = "Екатерина", SurName = "Иванова", Course = 4, Group = "BМ1"},
                    new SmartPhone {Model = "S10", Name = "Samsung", Os = "Android"}
                }
            };

            dictionary.Print("Вывод Dictionary");

            var employee = new Employee {Name = "Имя1", SurName = "Фамилия1", Position = "Должность1" };
            var smartPhone = new SmartPhone { Model = "S20", Name = "Samsung", Os = "Android" };

            dictionary.Add(employee, smartPhone);

            dictionary.Print("Вывод Dictionary после добавления нового ключа");

            // Попытка вставить дубликат ключа
            try
            {
                var smartPhone1 = new SmartPhone { Model = "7 Pro", Name = "OnePlus", Os = "Adroid" };
                dictionary.Add(employee, smartPhone1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка добавления ключа в словарь - {ex.Message}");
            }

            dictionary.Remove(employee);

            dictionary.Print("Вывод Dictionary после удаления по ключу");
        }

        /// <summary>
        /// Запуска примера работы со связным списком
        /// </summary>
        public static void RunLinkedList()
        {
            var linkedList = new LinkedList<int>();

            // Добавляем в начало списка число
            linkedList.AddFirst(1);
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(2);
            linkedList.AddFirst(6);
            linkedList.AddFirst(9);
            linkedList.AddFirst(43212);
            linkedList.AddFirst(6321);
            linkedList.AddFirst(2);
            linkedList.AddFirst(6142);
            linkedList.AddFirst(-123124);
            linkedList.AddFirst(0);
            linkedList.AddFirst(145);
            // Добавляем число перед последним элементом
            linkedList.AddBefore(linkedList.Last!, 3546);
            // Добавляем число после первого элемента
            linkedList.AddAfter(linkedList.First!, 3546);

            linkedList.Print("Вывод LinkedList");

            // Удаление элемента из середины
            int mid = linkedList.Count / 2;

            int i = 0;
            foreach (var item in linkedList)
            {
                if (i == mid)
                {
                    linkedList.Remove(item);
                    break;
                }

                i++;
            }

            linkedList.Print("Вывод LinkedList после удаления элемента из середины");
        }
    }
}
