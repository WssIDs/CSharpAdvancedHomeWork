using System;
using System.Collections.Generic;
using HomeWork2.UserCollection;
using Utils.Helpers;
using Utils.Menu;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<MenuItem>
            {
                new MenuItem("UserCollection", CollectionEnumerations.UserCollection),
                new MenuItem("GenericClass", CollectionEnumerations.GenericClass),
                new MenuItem("Выйти из приложения", CollectionEnumerations.None)
            };

            var menu = new Menu("Домашнее задание 2", items);

            menu.Show(0);
            while (true)
            {
                var cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        menu.UpPosition();
                        break;
                    case ConsoleKey.DownArrow:
                        menu.DownPosition();
                        break;
                    case ConsoleKey.Enter:
                        switch (menu.Type)
                        {
                            case CollectionEnumerations.UserCollection:
                                {
                                    menu.RunAction(UserCollectionExample.RunUserCollection);
                                    break;
                                }
                            case CollectionEnumerations.GenericClass:
                            {
                                menu.RunAction(UserCollectionExample.RunGenericClass);
                                break;
                            }
                            default:
                                {
                                    Environment.Exit(0);
                                    break;
                                }
                        }

                        break;
                    default:
                        menu.Show(menu.Position);
                        break;
                }
            }
        }
    }
}
