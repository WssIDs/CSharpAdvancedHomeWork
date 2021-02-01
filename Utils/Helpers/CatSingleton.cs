using System;
using System.Collections.Generic;
using System.Text;
using Utils.Entity;

namespace Utils.Helpers
{
    /// <summary>
    /// Класс одиночка Кот
    /// </summary>
    public class CatSingleton
    {
        private static Cat _instance;

        private CatSingleton()
        { }

        public static Cat GetInstance() => _instance ??= new Cat("Барсик");
    }
}
