using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal interface IVehicle
    {
        public void Drive(int driveLength);
        public bool Refuel(int gasVolume);
        

    }
}
