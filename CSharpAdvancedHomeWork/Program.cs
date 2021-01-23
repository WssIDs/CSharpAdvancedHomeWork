using System;
using System.Collections.Generic;
using Utils.Menu;

namespace CSharpAdvancedHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<MenuItem>
            {
                new MenuItem("  Меню 1                                   ", 10),
                new MenuItem("  Меню 2                                   ", 11),
                new MenuItem("  Меню 3                                   ", 12),
                new MenuItem("  Выйти из приложения                      ", 13)
            };

            var menu = new Menu("Домашнее задание 1", items);

            menu.Show(0, 8);
            while (true)
            {
                var cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.UpArrow) menu.UpPosition();
                else if (cki.Key == ConsoleKey.DownArrow) menu.DownPosition();
                else if (cki.Key == ConsoleKey.Enter)
                {
                    switch (menu.Position)
                    {
                        case 0:
                        {
                            break;
                        }
                        case 1:
                        {
                            break;
                        }
                        case 2:
                        {
                            //menu.Show(menu.Position, 8);
                            break;
                        }

                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
