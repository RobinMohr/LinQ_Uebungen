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
            //Aufgabe 14

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            string newstr = listOfString.FirstOrDefault(en => en == "o");
            listOfString.Remove(newstr);

            var _result = from z in listOfString
                          select z;

            foreach (var z in _result)
            {
                Console.WriteLine(z);
            }


            Console.ReadKey();
        }
    }
}
