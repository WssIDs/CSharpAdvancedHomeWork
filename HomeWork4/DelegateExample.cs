using System;
using System.Collections.Generic;
using System.Text;
using Utils.Entity;
using Utils.Helpers;

namespace HomeWork4
{
    delegate Computer ComputerDelegate();

    delegate T GenericDelegate<out T, in TV>(TV param);

    /// <summary>
    /// 
    /// </summary>
    public static class DelegateExample
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RunDelegate()
        {
            ComputerDelegate computerDelegate = () => new Computer();
            computerDelegate().ComputerPrint();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RunGenericDelegate()
        {
            GenericDelegate<int, Computer> genericDelegate = (Computer computer) => computer.GetRandom();
            Console.WriteLine($"Случайное число из обобщенного делегата - {genericDelegate.Invoke(new Computer())}");

            GenericDelegate<string, int> genericDelegate1 = (x) => (x * x).ToString();
            int number = new Random().Next(0,50);
            Console.WriteLine($"Квадрат числа {number} - {genericDelegate1.Invoke(number)}");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RunEvent()
        {
            // Если кот не singleton
            new Dog(false).Cat.WakeUp();
            new Human(false).Cat.WakeUp();
            new Mouse(false).Cat.WakeUp();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RunEventSingleton()
        {
            // Если кот singleton
            _ = new Dog(true);
            _ = new Human(true);
            _ = new Mouse(true);

            CatSingleton.GetInstance().WakeUp();
        }
    }
}
