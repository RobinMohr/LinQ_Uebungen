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

            var even = from num in numbers
                       where num % 2 == 0
                       select num;

            Console.WriteLine("Das sind die Geraden Zahlen:");
            foreach (int num in even)
            {
                Console.WriteLine(num);
            }

            //Aufgabe 2

            var odd = from num in numbers
                       where num % 2 != 0
                       select num;

            Console.WriteLine("Das sind die Ungeraden Zahlen:");
            foreach (int num in odd)
            {
                Console.WriteLine(num);
            }

            //Aufgabe 3

            var arr1 = new[] { 3, 9, 2, 8, 6, 5, };

            var arr2 = from num in arr1
                       where num * num > 20
                       select num;

            Console.WriteLine("Das sind die Zahlen, deren Qadratzahl größer als 20 ist:");
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
                Console.WriteLine(num*num);
                Console.WriteLine();
            }

            //Aufgabe 4

            int[] arr3 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 9, 5, 4, 9, 6, 2 };

            var arr4 = from num in arr3
                       group num by num into y
                       select y;
                        foreach (var num in arr4)
                        {
                            Console.WriteLine("Nummer " + num.Key + " ist " + num.Count()+" mal vorhanden.");
                        }

            //Aufgabe 5

            string str1 = "w3resource";

            var str2 = from num in str1
                       group num by num into y
                       select y;
            foreach (var str in str2)
            {
                Console.WriteLine("Buchstabe " + str.Key + " ist " + str.Count() + " mal vorhanden.");
            }

            //Aufgabe 6

            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var nums1 = from num in nums
                       group num by num into y
                       select y;
            foreach (var num in nums1)
            {
                Console.WriteLine("Nummer " + num.Key + " ist " + num.Count() + " mal vorhanden. \nDie Zahl mit der Anzhal ihres Auftretens ergibt " + num.Key * num.Count());
            }





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
