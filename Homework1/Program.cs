using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            #region Ödev1 
            /* Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int n =int.Parse(Console.ReadLine());
                int[] dizi = new int[n];
              Console.WriteLine($"{n} adet sayı girin...");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}. Sayıyı giriniz");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girmiş olduğunuz çift sayılar...");
            Console.WriteLine(" ");
            foreach(int sayi in dizi)
            {
                if (sayi % 2 == 0) Console.WriteLine(sayi);
            }
            */
            #endregion

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            #region ödev2
            /* Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen pozitif bir sayı daha giriniz");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine($"{n} adet sayı girin...");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. Sayıyı giriniz");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Girmiş olduğunuz sayılardan {m} sayısına eşit olan ya da tam bölünen sayılar...");
            Console.WriteLine(" ");
            foreach (int sayi in dizi)
            {
                if (sayi % m == 0||sayi==m) Console.WriteLine(sayi);
            }*/
            #endregion

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            #region ödev3
            /* Console.Write("Lütfen pozitif bir sayı giriniz: ");
             int n = int.Parse(Console.ReadLine());
             string[] dizi = new string[n];
             Console.WriteLine($"{n} adet kelime girin...");

             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine($"{i + 1}. kelimeyi giriniz");
                 dizi[i] = Console.ReadLine();
             }
             Array.Reverse(dizi);
             Console.WriteLine("Girmiş olduğunuz kelimeler...");
             Console.WriteLine(" ");
              foreach(string kelime in dizi)
             {
                 Console.WriteLine(kelime);
             }
            */
            #endregion

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            #region ödev4
           /* int sayac = 0;
            Console.Write("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');

            string liste = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ"
                           + "qwertyuıopğüasdfghjklşizxcvbnmöç";

            
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine($"Cümlede toplam {kelimeler.Length} kelime ve {sayac} harf vardır.");
           */
            #endregion
            Console.ReadKey();
        }
    }
}
