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
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            Console.WriteLine("Wie viele Nummern sollen in der zufällig generierten Liste sein?");
            int amount = Convert.ToInt32(Console.ReadLine());

            List<int> rdm_numbers = List_With_Numbers(amount);
            

            foreach (int num in rdm_numbers)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }
            }

            Console.WriteLine("Gerade Zahlen:");
            foreach (int num in even)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Ungerade Zahlen:");
            foreach (int num in odd)
            {
                Console.WriteLine(num);
            }




            Console.ReadKey();
        }
        static List<int> List_With_Numbers(int amount)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {                
                list.Add(random.Next(0, 1001));
            }
            return list;
        }
    }
}
