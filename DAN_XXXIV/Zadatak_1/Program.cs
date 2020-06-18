using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        public static object l = new object();
        static int cash = 10000;

        public static void RaisingMoney(Thread t)
        {


            lock (l)
            {
                Random random = new Random();
                int amount = random.Next(100, 10001);
                Thread.Sleep(15);

                if (cash >= amount)
                {

                    Console.WriteLine(t.Name + " to withdraw " + amount + " RSD were withdrawn from the ATM");
                    cash = cash - amount;
                    Console.WriteLine(cash + "RSD left at the ATM");

                }
                else
                {
                    Console.WriteLine(t.Name + " The user tried to withdraw " + amount + " RSD but there is not enough money at the ATM");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {


            int numUsers1;
            int numUsers2;
            Console.WriteLine("***WELCOME TO THE BANK***\n");
            Console.WriteLine("Enter the number of users of the first ATM:");
            bool e = int.TryParse(Console.ReadLine(), out numUsers1);
            Console.WriteLine("Enter the number of users of the second ATM");
            bool c = int.TryParse(Console.ReadLine(), out numUsers2);
            int user = numUsers1 + numUsers2;

            Thread[] thr = new Thread[user];

            for (int i = 0; i < numUsers1; i++)
            {

                Thread t = new Thread(() => RaisingMoney(Thread.CurrentThread))
                {

                    Name = string.Format("User_{0} ATM1", i + 1)

                };

                thr[i] = t;

                
            }

            for (int i= numUsers1; i < user; i++)
            {

                Thread t = new Thread(() => RaisingMoney(Thread.CurrentThread))
                {

                    Name = string.Format("User_{0} ATM2", i + 1)

                };
                thr[i] = t;

               
            }
            foreach (var item in thr)
            {
                item.Start();
            }
            
        }
    }
}

