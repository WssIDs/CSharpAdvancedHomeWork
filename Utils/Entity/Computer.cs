using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Entity
{
    public delegate void ComputerPrint();

    public class Computer
    {
        public ComputerPrint ComputerPrint;

        public Computer()
        {
            ComputerPrint = Print;
        }

        public int GetRandom() => new Random().Next();

        private void Print()
        {
            Console.WriteLine($"Компьютер что-то начал выводить в консоль => Тип делегата - {typeof(ComputerPrint)}");
        }
    }
}
