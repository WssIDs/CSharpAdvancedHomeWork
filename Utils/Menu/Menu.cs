using System;
using System.Collections.Generic;
using Utils.Helpers;

namespace Utils.Menu
{
    /// <summary>
    /// Элемент меню
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Текст элемента меню
        /// </summary>
        public string MenuText { get; }

        /// <summary>
        /// Позиция элемента меню
        /// </summary>
        public int MenuPosition { get; set; }

        public CollectionEnumerations Type { get; }

        public MenuItem(string text)
        {
            MenuText = text;
            MenuPosition = 0;
        }

        public MenuItem(string text, CollectionEnumerations type)
        {
            MenuText = text;
            MenuPosition = 0;
            Type = type;
        }

        public override string ToString()
        {
            return $"Наименование меню - ({MenuText} - {MenuPosition})";
        }
    }

    /// <summary>
    /// Класс Меню
    /// </summary>
    public class Menu
    {
        private int _width;
        private int _height;
        /// <summary>
        /// Коллекция элементов меню
        /// </summary>
        private readonly List<MenuItem> _menuItems;

        /// <summary>
        /// Свойство для возвращения позиции курсора (readonly)
        /// </summary>
        public int Position { get; private set; }

        public CollectionEnumerations Type { get; private set; }

        /// <summary>
        /// Конструктор класса меню
        /// </summary>
        /// <param name="title">Наименование окна консоли</param>
        /// <param name="items">Коллекция элементов меню</param>
        public Menu(string title, List<MenuItem> items)
        {
            _menuItems = items;

            _height = Console.WindowHeight;
            _width = Console.WindowWidth;

            Console.Title = title;
            Console.Clear();
        }

        /// <summary>
        /// Обработка нажатия кнопки вверх
        /// </summary>
        public void UpPosition()
        {
            if (Position > 0) Position--;
            else Position = _menuItems.Count - 1;

            Type = _menuItems[Position].Type;

            Show(Position);
        }

        /// <summary>
        /// Обработка нажатия кнопки вниз
        /// </summary>
        public void DownPosition()
        {
            if (Position < _menuItems.Count - 1)
            {
                Position++;
            }
            else Position = 0;

            Type = _menuItems[Position].Type;

            Show(Position);
        }

        /// <summary>
        /// Вывод текста в меню
        /// </summary>
        /// <param name="leftPosition">левая позиция курсора</param>
        /// <param name="topPosition">верхняя позиция курсора</param>
        /// <param name="inText">Текст</param>
        public void ShowCustomText(int leftPosition, int topPosition, string inText)
        {
            Show(Position);
            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write(inText);
            Console.SetCursorPosition(79, 24);
        }

        /// <summary>
        /// Отображение меню с учетом позиции курсора
        /// </summary>
        /// <param name="position">позиция курсора</param>
        public void Show(int position)
        {
            _height = Console.WindowHeight;
            _width = Console.WindowWidth;

            const string mainMenuTitle = "ГЛАВНОЕ МЕНЮ";

            var startPos = _height / 2 - _menuItems.Count / 2 - 2;

            Console.Clear();
            Console.SetCursorPosition(_width/2 - mainMenuTitle.Length/2, startPos++);
            Console.WriteLine(mainMenuTitle);
            Console.SetCursorPosition(_width / 2 - 20 / 2, startPos++);
            Console.WriteLine(new string('-', 20));


            foreach (var menuItem in _menuItems)
            {
                menuItem.MenuPosition = startPos++;
                Console.SetCursorPosition(_width / 2 - menuItem.MenuText.Length / 2, menuItem.MenuPosition);
                Console.WriteLine(menuItem.MenuText);
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


            Console.SetCursorPosition(_width / 2 - _menuItems[position].MenuText.Length / 2, _menuItems[position].MenuPosition);
            Console.WriteLine(_menuItems[position].MenuText);

            Console.ResetColor();
            Console.SetCursorPosition(_width / 2 - _menuItems[position].MenuText.Length / 2 - 1, _menuItems[position].MenuPosition);
        }

        /// <summary>
        /// Запуск действия для вывода в консоль
        /// </summary>
        /// <param name="action"></param>
        public void RunAction(Action action)
        {
            PrepareToOutPut();

            // отлавливание ошибок
            try
            {
                action?.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ReturnToMenu();
        }

        /// <summary>
        /// Подготовить консоль к выводу
        /// </summary>
        private void PrepareToOutPut()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }

        /// <summary>
        /// Вернуться в меню
        /// </summary>
        private void ReturnToMenu()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы вернуться в меню");
            Console.ReadKey();
            Show(Position);
        }
    }
}
