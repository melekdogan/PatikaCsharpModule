using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While 
            // 1'den başlayarak Console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp ekrana yazdıran program

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' Dan 'z'Ye kadar olan tüm harfleri console a yazdır

            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }
            Console.Write("\n");
            Console.WriteLine("******** Foreach ************");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach(string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.ReadKey();
        }
    }
}
