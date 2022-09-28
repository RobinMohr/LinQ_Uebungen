using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 9

            List<int> ints = new List<int>();

            Console.WriteLine("Wie viele Einträge soll die Liste haben?");
            int amount = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                ints.Add(random.Next(1,1001));
            }

            var sorted = from x in ints
                         orderby x
                         select x;

            Console.WriteLine("Wie viele Zahlen willst du Anzeigen lassen)");
            int amount1 = Convert.ToInt32(Console.ReadLine());

            foreach (int x in sorted.Take(amount1))
            {
                Console.WriteLine(x);
            }
            






            Console.ReadKey();


        }        
    }
}
