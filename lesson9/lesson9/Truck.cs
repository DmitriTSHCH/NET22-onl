using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Truck : Car
    {
        public Truck(int _gasTank) : base(_gasTank)
        {
            fuelСonsumption = 10;
            Console.WriteLine($"Грузовик создан\nБензин: {gasTank}\nРасход: {fuelСonsumption}");
        }
    }
}
