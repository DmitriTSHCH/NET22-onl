using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Rectangle : Triangle
    {
        private double width = 0;
        private double height = 0;

        public override void PrintParameters()
        {
            Console.WriteLine
                ($"      C\n      *------------*\n    /\\|            |\nВысота|            |\n    \\/|            |\n      *------------*\n      A  <Ширина>  B\nШирина: {width}\nВысота: {height}\nПериметр: {GetPerimeter()}\nПлощадь: {GetArea()}");
        }
        public override void SetParameters()
        {
            /*
            Console.WriteLine("Введите координаты\nТочкаA\nX:");
            double inpX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y:");
            double inpY = Convert.ToDouble(Console.ReadLine());
            PointA.SetCoordinate(inpX, inpY);
            */
            Console.WriteLine("Создание прямоугольника\nВведите ширину: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            height = Convert.ToDouble(Console.ReadLine());
            PointB.SetCoordinate(width, PointA.posY);
            PointC.SetCoordinate(PointA.posX, height);
        }
        public override double GetPerimeter()
        {
            return (width * 2 + height * 2);
        }
        public override double GetArea()
        {
            return (width * height);
        }
    }
}
