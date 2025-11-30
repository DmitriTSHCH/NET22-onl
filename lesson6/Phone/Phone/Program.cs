using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("Dan",80299996633,800);
            Phone phone2 = new Phone("Sam", 80299002050, 600);
            Phone phone3 = new Phone("Cate", 80298585222, 700);

            Console.WriteLine("--------------------------------------------------------------------------------");

            phone1.ReceiveCall();

            Console.WriteLine("--------------------------------------------------------------------------------");

            phone2.SendMessage("*сообщение*");

        }
    }
}
