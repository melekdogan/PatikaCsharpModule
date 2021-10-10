﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[1]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen  n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısının giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write($"Lütfen {i+1}. sayısını giriniz");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine($"Ortalama: {toplam/diziUzunlugu}");
            Console.ReadKey();
        }
    }
}
