using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class AuxiliaryClass
    {
        //Read string variable
        public static string ReadText()
        {
            string text = "";
            while (text == null || text.Equals(""))
            {
                text = Console.ReadLine();
            }
            return text;
        }
        // Read DateTime
        public static DateTime ReadDate()
        {
            DateTime date;
            while (DateTime.TryParse(Console.ReadLine(), out date) == false)
            {
                Console.Write("Wrong date, enter the correct date: ");
            }
            return date;
        }

        //Read Int32 variable
        public static int ReadInteger()
        {
            int number;
            while (Int32.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("Wrong input, enter the number again: ");
            }
            return number;
        }

        //Read float variable
        public static float ReadFloat()
        {
            float number;
            while (Single.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("GRESKA - Pogresno unsesena vrednost, pokusajte ponovo: ");
            }
            return number;
        }

        //Read char variable
        public static char ReadChar()
        {
            char number;
            while (Char.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("GRESKA - Pogresno unsesena vrednost, pokusajte ponovo: ");
            }
            return number;
        }

        //yes or no decision
        public static bool Confirm(string text)
        {
            Console.WriteLine("Do you want " + text + " [y/n]:");
            char decision = ' ';
            while (!(decision == 'y' || decision == 'n'))
            {
                decision = Char.ToLower(ReadChar());
                if (!(decision == 'y' || decision == 'n'))
                {
                    Console.WriteLine("The options are y ili n");
                }
            }
            return decision == 'y' ? true : false;
        }

        public static bool IsInt(string s)
        {
            int number;
            if (Int32.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

        public static bool IsLong(string s)
        {
            long number;
            if (Int64.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

        public static bool IsFloat(string s)
        {
            float number;
            if (Single.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

        public static bool IsDouble(string s)
        {
            double number;
            if (Double.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

        public static bool isBoolean(string s)
        {
            bool number;
            if (Boolean.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

        public static bool IsDate(string s)
        {
            DateTime number;
            if (DateTime.TryParse(s, out number))
            {
                return true;
            }
            return false;
        }

    }
}
