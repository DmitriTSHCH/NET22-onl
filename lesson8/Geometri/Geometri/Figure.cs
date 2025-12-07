using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal abstract class Figure
    {
        protected Coordinate PointA = new Coordinate(0,0);

        public virtual void PrintParameters() 
        { 
            
        }
        public virtual void SetParameters()
        {

        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
        public virtual double GetArea()
        {
            return 0;
        }
    }
    internal class Coordinate
    {
        public double posX { get; private set; }
        public double posY { get; private set; }

        public Coordinate(double _posX, double _posY)
        {
            posX = _posX;
            posY = _posY;
        }
        public void Print()
        {
            Console.WriteLine($"X: {posX}; Y: {posY}");
        }
        public void SetCoordinate(double _posX, double _posY)
        {
            posX = _posX;
            posY = _posY;
        }
    }
}
