using System;
using System.Collections.Generic;
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
            //Aufgabe 11

            string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };

            string newstring = String.Join(", ", arr1
                          .Select(s => s.ToString())
                          .ToArray());
            Console.WriteLine(newstring);


            Console.ReadKey();


        }        
    }
}
