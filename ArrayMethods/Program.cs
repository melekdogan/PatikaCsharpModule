using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort 
            int[] sayiDizisi = { 23,12,4,86,72,3,11,17};
            Console.WriteLine("********** Sırasız Dizi *************");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******* Sıralı Dizi ********");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear 
            Console.WriteLine("*********** Array Clear ************");
            //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı sıfırlar 
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("************ Array Reverse ***************");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // IndexOf
            Console.WriteLine("*************** Array IndexOf ***************");
            Console.WriteLine( Array.IndexOf(sayiDizisi,23) );

            //Resize 
            Console.WriteLine("********* Array Resize **********");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }
    }
}
