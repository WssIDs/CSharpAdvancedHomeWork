using System;

namespace HomeWork11
{
    public class Theory
    {
        private int _num;

        private readonly object _lockMethod = new object();


        public Theory()
        {
            _num = 0;
        }


        public void First()
        {
            while (true)
            {
                lock (_lockMethod)
                {
                    if (_num == 0)
                    {
                        _num = 1;
                        Console.WriteLine("1");
                        break;
                    }
                }
            }
        }

        public void Second()
        {
            while (true)
            {
                lock (_lockMethod)
                {
                    if (_num == 1)
                    {
                        _num = 2;
                        Console.WriteLine("2");
                        break;
                    }
                }
            }
        }

        public void Third()
        {
            while (true)
            {
                lock (_lockMethod)
                {
                    if (_num != 2) continue;
                    _num = 0;
                    Console.WriteLine("3");
                    break;
                }
            }
        }
    }
}
