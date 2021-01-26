using System;

namespace Utils.Entity
{
    public interface IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        string GetInfo();
    }

    public class Student : IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public string GetInfo()
        {
            return $"Фамилия Имя - {SurName} {Name} (Курс - {Course}, Группа - {Group})";
        }
    }

    public class Employee : IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public string GetInfo()
        {
            return $"Фамилия Имя - {SurName} {Name} (Должность - {Position})";
        }
    }
}
