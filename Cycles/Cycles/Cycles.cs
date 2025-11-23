using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles_Arrays_Lists
{
    internal class Cycles
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("(1)Обоатное перечисление до 1;\n(2)Перечисление чисел кратных 7;\n(3)Последовательность Фибоначи\nВыберите нужную последовательность(введите номер варианта): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CountdownTo1();
                        break;
                    case "2":
                        EnumerationMultiplesOf7();
                        break;
                    case "3":
                        FibonacciSequence();
                        break;
                }
            }
        }

        public static void CountdownTo1()
        {
            Console.WriteLine("Введите число для начала перечисления до 1: ");

            for (int i = Convert.ToInt32(Console.ReadLine()); i > 0; i--)
            {
                Console.Write($"{i},");
            }

            Console.Write("\b.\n");
        }

        public static void EnumerationMultiplesOf7()
        {
            Console.Write("\bВывод чисел кратных 7.\nВведите до какого числа вывести последовательность: ");
            int limitNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; (i * 7) < limitNumber; i++)
            {
                Console.Write((i * 7) + ",");
            }

            Console.Write("\b.\n");
        }

        public static void FibonacciSequence()
        {
            Console.Write("\bВывод последовательности Фибоначчи.\nВведите до какого числа вывести последовательность: ");
            int limitNumber = Convert.ToInt32(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;
            Console.Write($"{num1},{num2},");

            while (limitNumber > (num1 + num2))
            {
                int numN = num2;
                num2 = num1 + num2;
                num1 = numN;
                Console.Write($"{num2},");
            }

            Console.Write("\b.\n");
        }
    }
}
