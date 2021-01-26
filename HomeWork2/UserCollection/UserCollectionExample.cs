using System;
using System.Collections.Generic;
using System.Text;
using HomeWork2.GenericClass;
using Utils.Entity;
using Utils.Helpers;

namespace HomeWork2.UserCollection
{
    public static class UserCollectionExample
    {
        public static void RunUserCollection()
        {
            var phones = new List<IPhone>
            {
                new Phone {Model = "PXFGH1345", Name = "Philips"},
                new Phone {Model = "PXFGH1345", Name = "Philips"},
                new SmartPhone {Model = "P40 Pro", Name = "Huawei", Os = "Harmony"},
                new SmartPhone {Model = "10 Max", Name = "IPhone", Os = "IOS"},
                new SmartPhone {Model = "S10", Name = "Samsung", Os = "Android"},
            };

            var phoneCollection = new PhoneCollection<IPhone>(phones);

            phoneCollection.Print("Вывод пользовательской коллекции");

            try
            {
                phoneCollection.Remove(3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var myPhone = new Phone {Model = "hfgdweh", Name = "MyPhone"};

            phoneCollection.Add(myPhone);

            phoneCollection.Print("Вывод пользовательской коллекции после добавления элемента");

            try
            {
                phoneCollection.Remove(3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            phoneCollection.Print("Вывод пользовательской коллекции после удаления элемента");
        }

        public static void RunGenericClass()
        {
            var phones = new List<GenericPhone<IPhone, int>>
            {
                new GenericPhone<IPhone, int>(new Phone {Model = "PXFGH1345", Name = "Philips"}, 5),
                new GenericPhone<IPhone, int>(new Phone {Model = "PXFGH1345", Name = "Philips"}, 10),
                new GenericPhone<IPhone, int>(new SmartPhone {Model = "P40 Pro", Name = "Huawei", Os = "Harmony"}, 0),
                new GenericPhone<IPhone, int>(new SmartPhone {Model = "10 Max", Name = "IPhone", Os = "IOS"}, 40),
                new GenericPhone<IPhone, int>(new SmartPhone {Model = "S10", Name = "Samsung", Os = "Android"}, 22),
            };

            foreach (var item in phones)
            {
                item.ShowInfo();
            }

        }

        /// <summary>
        /// Вывод коллекции в цикле foreach
        /// </summary>
        /// <param name="collection">Список элементов</param>
        /// <param name="message">Сообщение какая коллекция будет выводиться</param>
        private static void Print(this IEnumerable<IPhone> collection, string message)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.WriteLine("--------------------");
        }
    }
}
