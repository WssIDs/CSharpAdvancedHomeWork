using System;

namespace Utils.Entity
{
    /// <summary>
    /// Сущность кот
    /// </summary>
    public class Cat
    {
        public event Action WakeUpEvent;

        private readonly string _name;

        public Cat(string name)
        {
            _name = name;
        }

        public void WakeUp()
        {
            Console.WriteLine($"Кот по имени - {_name} вызвал событие");
            WakeUpEvent?.Invoke();
        }
    }
}
