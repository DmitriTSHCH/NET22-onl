using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chars_Strings
{
    internal class CharsAndStrings
    {
        static void Main(string[] args)
        {
            BankCard card1 = new BankCard();
            BankCard card2 = new BankCard();
            BankCard card3 = new BankCard();
            while (true)
            {
                Console.WriteLine("Выберите одну из трех карт");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                        case 1:
                        card1.SelectOperation();
                        break;
                        case 2:
                        card2.SelectOperation();
                        break;
                        case 3:
                        card3.SelectOperation();
                        break;
                }
            }
        }
    }
}