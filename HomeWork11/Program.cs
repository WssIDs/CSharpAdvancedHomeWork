using System;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork11
{
    class Program
    {
        private static Mutex _m;

        static void Main(string[] args)
        {
            _m = new Mutex(true, "Home11", out var isNew);

            if (!isNew)
            {
                Console.WriteLine("Попытка запуска второй копии приложения. Запуск более одной копии приложения невозможен.");
                Console.WriteLine("Данная копия приложения будет закрыта");
                Console.ReadKey();
                return;
            }

            ThreadExample.DebitCredit();

            var theory = new Theory();

            var task1 = new Task(theory.First);
            var task2 = new Task(theory.Second);
            var task3 = new Task(theory.Third);

            task2.Start();
            task1.Start();
            task3.Start();

            Task.WaitAll(task3, task2, task1);

            Console.ReadKey();
        }
    }
}
