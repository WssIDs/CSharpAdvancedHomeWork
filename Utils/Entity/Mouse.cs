using System;
using System.Collections.Generic;
using System.Text;
using Utils.Helpers;

namespace Utils.Entity
{
    public class Mouse
    {
        public Cat Cat { get; }

        public Mouse(bool bIsSingleton)
        {
            if (bIsSingleton)
            {
                CatSingleton.GetInstance().WakeUpEvent += Pui;
            }
            else
            {
                Cat = new Cat("Алиса");
                Cat.WakeUpEvent += Pui;
            }
        }

        private void Pui()
        {
            Console.WriteLine("Мышь убежала");
        }
    }
}
