using System;
using System.ComponentModel;
using Utils.Helpers;

namespace Utils.Entity
{
    public class Dog
    {
        public Cat Cat { get; }

        public Dog(bool bIsSingleton)
        {
            if (bIsSingleton)
            {
                CatSingleton.GetInstance().WakeUpEvent += Gav;
            }
            else
            {
                Cat = new Cat("Мурзик");
                Cat.WakeUpEvent += Gav;
            }
        }

        private void Gav()
        {
            Console.WriteLine("Собака начала лаять и побежала за котом");
        }
    }
}
