using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        public static object l = new object();
        static int cash = 10000;

        public static void RaisingMoney(int amount)
        {


            Random random = new Random();
            amount = random.Next(100, 10001);
            lock (l)
            {
                if (cash >= amount)
                {
                    Console.WriteLine(amount + "RSD were withdrawn from the ATM");
                    cash = cash - amount;
                    Console.WriteLine(cash + "RSD left at the ATM");

                }
                else
                {
                    Console.WriteLine("There is not enough money at the ATM");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
        }
    }
}
