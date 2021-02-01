using System;
using System.Collections.Generic;
using System.Text;
using Utils.Helpers;

namespace Utils.Entity
{
    public class Human
    {
        public Cat Cat { get; }

        public Human(bool bIsSingleton)
        {
            if (bIsSingleton)
            {
                CatSingleton.GetInstance().WakeUpEvent += Say;
            }
            else
            {
                Cat = new Cat("Федор");
                Cat.WakeUpEvent += Say;
            }
        }

        void Say()
        {
            Console.WriteLine("Человек сказал, хороший котик и начал гладить");
        }
    }
}
