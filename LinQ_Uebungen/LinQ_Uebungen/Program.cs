using LinQ_Uebungen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Uebungen
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Aufgabe 16

            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };

            var set3 = from x in set1
                       from y in set2
                       select x + y;

            foreach (var x in set3)
            {
                Console.WriteLine(x);
            }


            Console.ReadKey();
        }
    }
}
