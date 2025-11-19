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
            string oper = Console.ReadLine();
            Console.WriteLine("Введите число1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            string continueCheckInput;

            do
            {
                switch (oper)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Результат = " + (result));
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Результат = " + (result));
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Результат = " + (result));
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Результат = " + (result));
                        break;
                }
                Console.WriteLine("Желаете продолжить? (Y/N)");
                continueCheckInput = Console.ReadLine();

                if (continueCheckInput == "N")
                {
                    break;
                }
                num1 = result;
                Console.WriteLine("Выберете операцию (+,-,/,*):");
                oper = Console.ReadLine();
                Console.WriteLine("Введите число:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            while ( continueCheckInput == "Y" );


            Console.ReadKey();
        }
    }
}
