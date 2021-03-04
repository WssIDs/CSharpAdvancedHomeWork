using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeWork11
{
    public class BankAccount
    {
        private double _balance = 0.0;

        private readonly object _lock = new object();

        public void Print()
        {
            Console.WriteLine($"Баланс {_balance} Thread Id = {Thread.CurrentThread.ManagedThreadId}");
        }

        public void Credit(double credit)
        {
            lock (_lock)
            {
                _balance -= credit;
                Console.WriteLine($"Кредит -{credit} Thread Id = {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public void Debit(double debit)
        {
            lock (_lock)
            {
                _balance += debit;
                Console.WriteLine($"Дебит +{debit} Thread Id = {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
