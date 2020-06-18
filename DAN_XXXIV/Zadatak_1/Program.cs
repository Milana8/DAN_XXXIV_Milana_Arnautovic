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
        /// <summary>
        /// ATM withdrawal method
        /// </summary>
        /// <param name="t"></param>
        public static void RaisingMoney(Thread t)
        {


            lock (l) //locking one transaction
            {
                Random random = new Random();
                int amount = random.Next(100, 10001); //the amount that the user can withdraw is a random number between 100 and 10000
                Thread.Sleep(15);

                if (cash >= amount)
                {

                    Console.WriteLine(t.Name + " to withdraw " + amount + " RSD");
                    cash = cash - amount;
                    Console.WriteLine(cash + "RSD left at the ATM\n");

                }
                else
                {
                    Console.WriteLine(t.Name + " The user tried to withdraw " + amount + " RSD but there is not enough money at the ATM\n");
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
            Console.WriteLine("Enter the number of users of the second ATM:");
            bool c = int.TryParse(Console.ReadLine(), out numUsers2);
            int user = numUsers1 + numUsers2;

            Thread[] thr = new Thread[user];

            for (int i = 0; i < numUsers1; i++)
            {

                Thread t = new Thread(() => RaisingMoney(Thread.CurrentThread)) //creating threads
                {

                    Name = string.Format("User_{0} from the ATM1", i + 1) //naming threads

                };

                thr[i] = t;

                
            }

            for (int i= numUsers1; i < user; i++)
            {

                Thread t = new Thread(() => RaisingMoney(Thread.CurrentThread)) //creating threads
                {

                    Name = string.Format("User_{0} from the ATM2", i + 1) //naming threads

                };
                thr[i] = t;

               
            }
            foreach (var item in thr)
            {
                item.Start(); //starting threads
            }
            
        }
    }
}

