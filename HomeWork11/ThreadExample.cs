using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork11
{
    public static class ThreadExample
    {
        public static void DebitCredit()
        {
            var task1 = new Task(() =>
            {
                var bankAccount = new BankAccount();

                for (var i = 0; i < 5; i++)
                {
                    var number = new Random().Next(2);

                    if (number == 0)
                    {
                        bankAccount.Debit(20);
                    }
                    else
                    {
                        bankAccount.Credit(10);
                    }
                }

                bankAccount.Print();
            });

            var task2 = new Task(() =>
            {
                var bankAccount = new BankAccount();

                for (var i = 0; i < 5; i++)
                {
                    var number = new Random().Next(2);

                    if (number == 0)
                    {
                        bankAccount.Debit(100);
                    }
                    else
                    {
                        bankAccount.Credit(5);
                    }
                }

                bankAccount.Print();
            });

            task1.Start();
            task2.Start();
            //taskCredit.Start();

            task1.Wait();
            task2.Wait();

            //bankAccount.Print();
        }
    }
}
