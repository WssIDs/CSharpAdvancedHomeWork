using System;
using System.Collections.Generic;
using System.Text;
using Utils.Entity;

namespace HomeWork2.GenericClass
{
    public class GenericPhone<T,TV> where T : IPhone where TV : struct
    {
        private T _phone;
        private TV _count;

        public GenericPhone(T phone, TV count)
        {
            _phone = phone;
            _count = count;
        }

        public (T, TV) GetData()
        {
            return (_phone, _count);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Телефон - {_phone.GetInfo()} | Количество - {_count}");
        }
    }
}
