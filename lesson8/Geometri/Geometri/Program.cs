using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
{
                new Triangle(),
                new Circle(),
                new Rectangle(),
                new Rectangle(),
                new Circle(),
            };

            double sumPerimetr=0;
            double sumArea=0;

            foreach (var figure in figures)
            {
                bool check = false;
                do
                {
                    try
                    {
                        figure.SetParameters();
                        check = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Неверный ввод. Введите число, используйте запятую как десятичный разделитель.");
                        continue;
                    }
                }
                while (!check);
                figure.PrintParameters();
                sumPerimetr += figure.GetPerimeter();
                sumArea += figure.GetArea();
            }
            Console.WriteLine($"\nСумма периметров: {sumPerimetr}\nСумма площадей: {sumArea}");
        }
    }
}