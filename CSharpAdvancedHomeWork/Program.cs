using System;
using System.Collections.Generic;
using HomeWork1.Collections;
using HomeWork1.GenericCollections;
using Utils.Helpers;
using Utils.Menu;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<MenuItem>
            {
                new MenuItem("ArrayList", CollectionEnumerations.ArrayList),
                new MenuItem("Stack", CollectionEnumerations.Stack),
                new MenuItem("Queue", CollectionEnumerations.Queue),
                new MenuItem("HashTable", CollectionEnumerations.HashTable),
                new MenuItem("Dictionary (Generic)", CollectionEnumerations.Dictionary),
                new MenuItem("LinkedList (Generic)", CollectionEnumerations.LinkedList),
                new MenuItem("Выйти из приложения", CollectionEnumerations.None)
            };

            var menu = new Menu("Домашнее задание 1", items);

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
                            case CollectionEnumerations.ArrayList:
                            {
                                menu.RunAction(CollectionListExample.RunArrayList);
                                break;
                            }
                            case CollectionEnumerations.Stack:
                            {
                                menu.RunAction(CollectionListExample.RunStack);
                                break;
                            }
                            case CollectionEnumerations.Queue:
                            {
                                menu.RunAction(CollectionListExample.RunQueue);
                                    break;
                            }
                            case CollectionEnumerations.HashTable:
                            {
                                menu.RunAction(CollectionListExample.RunHashTable);
                                break;
                            }
                            case CollectionEnumerations.Dictionary:
                            {
                                menu.RunAction(GenericCollectionListExample.RunDictionary);
                                break;
                            }
                            case CollectionEnumerations.LinkedList:
                            {
                                menu.RunAction(GenericCollectionListExample.RunLinkedList);
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
