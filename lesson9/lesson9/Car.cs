using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    public abstract class Car : IVehicle
    {
        protected int gasTank { get; set; }
        protected int fuelСonsumption { get; set; }

        public Car (int _gasTank) 
        {
            gasTank = _gasTank;
        }
        public virtual void Drive(int _driveLength) 
        {
            if (gasTank/fuelСonsumption > _driveLength)
            {
                Console.WriteLine("бензина хватит");
            }
            else
            {
                Console.WriteLine("бензина не хватит");
            }
        }
        public virtual bool Refuel(int _gasVolume) 
        {
            if (_gasVolume > 0)
            {
                gasTank += _gasVolume;
                return true;
            }
            return false;
        }


    }
}
