using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    public class SportCar : Car
    {
        public SportCar(int _gasTank) : base(_gasTank)
        {
            fuelСonsumption = 7;
            Console.WriteLine($"Спорткар создан\nБензин: {gasTank}\nРасход: {fuelСonsumption}");
        }
    }
}
