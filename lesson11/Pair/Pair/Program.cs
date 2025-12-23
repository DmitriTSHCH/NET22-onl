using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myPair = new Pair<int, string> ( 1, "Hello" );
            myPair.PairPrint();
        }
    }


    public class Pair<S,T> (S s, T t)
    {



        public void PairPrint()
        {
            Console.WriteLine($"{s}, {t}");
        }
    }
}