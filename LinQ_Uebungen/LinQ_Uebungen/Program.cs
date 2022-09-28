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
            //Aufgabe 15

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            listOfString.Remove("p");

            foreach (var x in listOfString)
            {
                Console.WriteLine(x);
            }


            Console.ReadKey();
        }
    }
}
