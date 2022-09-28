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
            //Aufgabe 1


            Console.WriteLine("Wie viele Nummern sollen in der Liste sein?");
            int amount = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = Rdm_Numbers(amount);

            var even = from nums in numbers
                       where nums % 2 == 0
                       select nums;

            Console.WriteLine("Das sind die Geraden Zahlen:");
            foreach (int num in even)
            {
                Console.WriteLine(num);
            }

            //Aufgabe 2

            var odd = from nums in numbers
                       where nums % 2 == 0
                       select nums;

            Console.WriteLine("Das sind die Ungeraden Zahlen:");
            foreach (int num in odd)
            {
                Console.WriteLine(num);
            }

            //Aufgabe 3

            var arr1 = new[] { 3, 9, 2, 8, 6, 5, };

            var arr2 = from nums in arr1
                       where nums * nums > 20
                       select nums;

            Console.WriteLine("Das sind die Zahlen, deren Qadratzahl größer als 20 ist:");
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
                Console.WriteLine(num*num);
            }

            //Aufgabe 4










            Console.ReadKey();


        }
        static List<int> Rdm_Numbers(int amount)
        {
            Random random = new Random();
            List<int> ints = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                ints.Add(random.Next(1,1001));
            }
            
            return ints;
        }

    }
}
