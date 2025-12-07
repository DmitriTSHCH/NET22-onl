using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class CharsAndStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем бензина в баке");
            SportCar sc1 = new SportCar(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите объем заправки");
            sc1.Refuel(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите расстояние");
            sc1.Drive(Convert.ToInt32(Console.ReadLine()));
        }
    }
}