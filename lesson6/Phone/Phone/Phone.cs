using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class Phone
    {
        protected string name;
        protected long number;
        protected int weight;

        public Phone() 
        {
            Print();
        }

        public Phone(string _name, long _number, int _weight) : this(_name, _number)
        {
            this.weight = _weight;
            Print();
        }

        public Phone(string _name, long _number)
        {
            this.name = _name;
            this.number = _number;
            Print();
        }

        public Phone(string _name)
        {
            this.name = _name;
            Print();
        }

        public void Print()
        {
            Console.WriteLine($"__________________\nname:{name}\nnumber:{number}\nweight:{weight}\n---------------");
        }

        public void ReceiveCall()
        {
            Console.WriteLine($"Принять звонок: {name}, {number}");
        }

        public void SendMessage(string _message)
        {
            Console.WriteLine($"Сообщение для {name}: {_message}");
        }
    }
}
