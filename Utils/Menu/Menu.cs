using System;
using System.Collections.Generic;

namespace Utils.Menu
{
    /// <summary>
    /// Элемент меню
    /// </summary>
    public readonly struct MenuItem
    {
        /// <summary>
        /// Текст элемента меню
        /// </summary>
        public readonly string MenuText;

        /// <summary>
        /// Позиция элемента меню
        /// </summary>
        public readonly int MenuPosition;

        public MenuItem(string text, int position)
        {
            MenuText = text;
            MenuPosition = position;
        }
    }

    /// <summary>
    /// Класс Меню
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Коллекция элементов меню
        /// </summary>
        private readonly List<MenuItem> _menuItems;

        /// <summary>
        /// Позиция курсора (private)
        /// </summary>
        private int _position = 0;

        /// <summary>
        /// Свойство для возвращения позиции курсора (readonly)
        /// </summary>
        public int Position => _position;


        /// <summary>
        /// Обработка нажатия кнопки вверх
        /// </summary>
        public void UpPosition()
        {
            if (_position > 0) _position--;
            else _position = _menuItems.Count - 1;
            Show(_position, 8);
        }

        /// <summary>
        /// Обработка нажатия кнопки вниз
        /// </summary>
        public void DownPosition()
        {
            if (_position < _menuItems.Count - 1) _position++;
            else _position = 0;
            Show(_position, 8);
        }

        /// <summary>
        /// Вывод текста в меню
        /// </summary>
        /// <param name="leftPosition">левая позиция курсора</param>
        /// <param name="topPosition">верхняя позиция курсора</param>
        /// <param name="inText">Текст</param>
        public void ShowCustomText(int leftPosition, int topPosition, string inText)
        {
            Show(_position, 8);
            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write(inText);
            Console.SetCursorPosition(79, 24);
        }

        /// <summary>
        /// Отображение меню с учетом позиции курсора
        /// </summary>
        /// <param name="position">позиция курсора</param>
        /// <param name="startPos">начальная позиция меню</param>
        public void Show(int position, int startPos)
        {
            Console.Clear();
            Console.SetCursorPosition(31, startPos++);
            Console.WriteLine("ГЛАВНОЕ МЕНЮ");
            Console.SetCursorPosition(30, startPos);
            Console.WriteLine(new string('-', 20));


            foreach (var menuItem in _menuItems)
            {
                Console.SetCursorPosition(23, menuItem.MenuPosition);
                Console.WriteLine(menuItem.MenuText);
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


            Console.SetCursorPosition(23, _menuItems[position].MenuPosition);
            Console.WriteLine(_menuItems[position].MenuText);

            Console.ResetColor();
            Console.SetCursorPosition(79, 24);
        }

        /// <summary>
        /// Конструктор класса меню
        /// </summary>
        /// <param name="title">Наименование окна консоли</param>
        /// <param name="items">Коллекция элементов меню</param>
        public Menu(string title, List<MenuItem> items)
        {
            _menuItems = items;

            Console.Title = title;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25); // width, height
            Console.Clear();
        }
    }
}
