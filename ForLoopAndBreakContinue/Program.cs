using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAndBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tektoplam = 0, cifttoplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2==1)
                {
                    tektoplam += i;
                }
                else
                {
                    cifttoplam += i;
                }             

            } Console.WriteLine($"Tek Toplam: {tektoplam}");
                Console.WriteLine($"Çift Toplam: {cifttoplam}");
            // Break, Continue
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                    
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
