using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>
            {
                new Director("Иван"),
                new Bookkeeper("Петр"),
                new Worker("Екатирина"),
                new Worker("Джон"),
                new Worker("Владислав"),
            };
            foreach (var worker in workers)
            {
                Console.Write($"\n {worker.GetName()} ");
                worker.PrintVocation();
            }
        }
    }
}