using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете операцию (+,-,/,*):");
            char oper = Console.ReadKey();
            Console.WriteLine("Выберете число1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберете число2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine((num1 + num2));
                    break;
                case '-':
                    Console.WriteLine((num1 - num2));
                    break;
                case '*':
                    Console.WriteLine((num1 * num2));
                    break;
                case '/':
                    Console.WriteLine((num1 / num2));
                    break;
            }
        }
    }
}
