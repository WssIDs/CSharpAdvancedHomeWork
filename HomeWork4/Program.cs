using System;
using System.Collections.Generic;
using Utils.Helpers;
using Utils.Menu;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<MenuItem>
            {
                new MenuItem("Delegate", DelegateEnumerations.Delegate),
                new MenuItem("GenericDelegate", DelegateEnumerations.GenericDelegate),
                new MenuItem("Event", DelegateEnumerations.Event),
                new MenuItem("EventSingleton", DelegateEnumerations.EventSingleton),
                new MenuItem("Выйти из приложения", DelegateEnumerations.None)
            };

            var menu = new Menu("Домашнее задание 4", items);

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
                            case DelegateEnumerations.Delegate:
                                {
                                    menu.RunAction(DelegateExample.RunDelegate);
                                    break;
                                }
                            case DelegateEnumerations.GenericDelegate:
                                {
                                    menu.RunAction(DelegateExample.RunGenericDelegate);
                                    break;
                                }
                            case DelegateEnumerations.Event:
                                {
                                    menu.RunAction(DelegateExample.RunEvent);
                                    break;
                                }
                            case DelegateEnumerations.EventSingleton:
                            {
                                menu.RunAction(DelegateExample.RunEventSingleton);
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
