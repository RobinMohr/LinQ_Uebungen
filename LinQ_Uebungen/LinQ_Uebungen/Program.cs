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
            //Aufgabe 17

            var setOfStringsArray = new string[] { "X", "Y", "Z" };
            var setOfIntsArray = new int[] { 1, 2, 3 };

            var neueArray = new string[setOfStringsArray.Length];

            var combine = setOfStringsArray.Zip(setOfIntsArray, (a, c) => new { setOfStringsArray = a, setOfIntsArray = c });

            foreach (var a in combine)
            {
                Console.WriteLine(a.setOfStringsArray + a.setOfIntsArray);
            }


            Console.ReadKey();
        }
    }
}
