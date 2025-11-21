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
            Console.WriteLine("Введите число для начала перечисления до 1: ");

            for (int i = Convert.ToInt32(Console.ReadLine()); i > 0; i--)
            {
                Console.Write($"{i},");
            }
            Console.Write("\n\nНажмите любую клавишу для продолжения");
            //Console.ReadKey();
            //Console.Write("");


        }
    }
}
