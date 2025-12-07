using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocation
{
    internal class Director : Employee
    {
        private string Name;
        private string Vocation = "Директор";
        public Director(string _name) 
        {
            Name = _name;
        }
        public override void SetName(string _name)
        {
            Name = _name;
        }
        public override string GetName()
        { 
            return Name;
        }
        public override void PrintVocation()
        {
            Console.WriteLine($"Должность: {Vocation}");
        }
    }
}
