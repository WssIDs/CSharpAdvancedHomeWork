using System;
using System.Collections.Generic;
using System.Text;
using HomeWork10._1.Attributes;

namespace HomeWork10._1.Classes
{
    [Main(Name = "Атрибут класса")]
    public class ClassRoom
    {
        [Main, Main(Name = "Test")]
        public string Name { get; set; }

        public int Number { get; set; }

        [Main, Main(Name = "Owner1"), Main(Name = "Owner2")]
        public string Owner { get; set; }

        public void PrintData()
        {
            Console.WriteLine($"{Name}({Number}) - {Owner}");
        }

        private void Print()
        {
            Console.WriteLine($"{Name}({Number}) - {Owner}");
        }
    }
}
