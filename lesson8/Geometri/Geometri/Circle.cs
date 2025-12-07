using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Circle : Rectangle
    {
        private double radius = 0;

        public override void PrintParameters()
        {
            Console.WriteLine
                ($"  -----\n /     \\B\n|  A*<->*--Радиус\n \\     /\n  -----\nРадиус: {radius}\nПериметр: {GetPerimeter()}\nПлощадь: {GetArea()}");
        }
        public override void SetParameters()
        {
            Console.WriteLine("Создание круга\nВведите радиус:");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public override double GetPerimeter()
        {
            return (2*Math.PI*radius);
        }
        public override double GetArea()
        {
            return (Math.PI*radius*radius);
        }
    }
}
