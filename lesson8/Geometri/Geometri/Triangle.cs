using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Triangle : Figure
    {
        protected Coordinate PointB = new Coordinate(0, 0);
        protected Coordinate PointC = new Coordinate(0, 0);
        private double SideAB = 0;
        private double SideBC = 0;
        private double SideCA = 0;

        public override void PrintParameters()
        {
            Console.WriteLine
                ("      C     \n      *     \n     / \\    \nX   /   \\   \n^  /     \\  \n|A*-------*B\n+-->Y       \nТочка А");
            PointA.Print();
            Console.WriteLine("Точка В");
            PointB.Print();
            Console.WriteLine("Точка C");
            PointC.Print();
            Console.WriteLine($"Длина AB: {SideAB}\nДлина BC: {SideBC}\nДлина CA: {SideCA}\nПериметр: {GetPerimeter()}\nПлощадь: {GetArea()}");
        }
        public override void SetParameters()
        {
            Console.WriteLine("Создание треугольника\nВведите координаты\nТочкаA\nX:");
            double inpX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y:");
            double inpY = Convert.ToDouble(Console.ReadLine());
            PointA.SetCoordinate(inpX, inpY);
            Console.WriteLine("Введите координаты\nТочкаB\nX:");
            inpX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y:");
            inpY = Convert.ToDouble(Console.ReadLine());
            PointB.SetCoordinate(inpX, inpY);
            Console.WriteLine("Введите координаты\nТочкаC\nX:");
            inpX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y:");
            inpY = Convert.ToDouble(Console.ReadLine());
            PointC.SetCoordinate(inpX, inpY);
            SideAB = Math.Sqrt(Math.Pow(PointA.posX + PointB.posX, 2) + Math.Pow(PointA.posY + PointB.posY, 2));
            SideBC = Math.Sqrt(Math.Pow(PointB.posX + PointC.posX, 2) + Math.Pow(PointB.posY + PointC.posY, 2));
            SideCA = Math.Sqrt(Math.Pow(PointC.posX + PointA.posX, 2) + Math.Pow(PointC.posY + PointA.posY, 2));
        }
        public override double GetPerimeter()
        {
            return (SideAB + SideBC + SideCA);
        }
        public override double GetArea()
        {
            return (Math.Abs((((PointB.posX - PointA.posX) * (PointC.posY - PointA.posY)) - ((PointC.posX - PointA.posX) * (PointB.posY - PointA.posY))) / 2));
        }
    }
}
