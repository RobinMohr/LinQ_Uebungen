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
            //Aufgabe 10

            Console.WriteLine("Bitte gib mehrere wörter von denen ein paar in Caps geschrieben sind.");
            string text = Console.ReadLine();

            var upWord = text.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));

            foreach (var word in upWord)
            {
                Console.WriteLine(word);
            }






            Console.ReadKey();


        }        
    }
}
