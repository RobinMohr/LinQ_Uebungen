using LinQ_Uebungen;
using System;
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
            //Audgabe 13

            //string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            //var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            //         .GroupBy(z => z, (fExt, extCtr) => new
            //         {
            //             Extension = fExt,
            //             Count = extCtr.Count()
            //         });

            //foreach (var m in fGrp)
            //    Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
            //Console.ReadLine();


            var ints = new int[] { 1, 2, 3 };
            var strings = new string[] { "X", "Y", "Z" };

            var all = from x in ints
                      from y in strings
                      select y + x;

            foreach (var x in all)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
