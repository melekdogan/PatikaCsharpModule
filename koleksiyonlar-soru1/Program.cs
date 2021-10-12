using System;
using System.Collections;

namespace koleksiyonlar_soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
             * (ArrayList sınıfını kullanarak yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

            ArrayList numbers = new ArrayList();//ReadLine ile alınacak tüm sayıların depolandığı ArrayList
            ArrayList PrimeNumbers = new ArrayList();// Yapılan Kontrollere göre asal olduğu tespit edilen sayıların depolandığı ArrayList 
            ArrayList NonPrimeNumbers = new ArrayList();// Yapılan Kontrollere göre asal olmadığı tespit edilen sayıların depolandığı ArrayList 
            #region Klavyeden sayı isteyip, bu sayılar için istenen kontrolleri yaptırdıktan sonra ArrayListlere ekledim, ya da hata mesajı verdirdim.
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Sayı Girin : ");
                string input = Console.ReadLine();
                if (IsNumber(input) && IsPositive(input))//Aşağıda klavyeden alınan değerin, yani gönderdiğimiz string parametrenin sayı olup olmadığını ve pozitif olup olmadığını, true ve false değerleriyle dönen metotları tanımladım. 
                    {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı ya negatif bir sayı ya da bir sayı değil. Lütfen tekrar deneyin. ");
                    break;
                }
            }
            #endregion

            #region Asal Olup Olmadığının Kontrolünün Yapıldığı kod blokları
            foreach (int item in numbers)
            {
                if (IsPrime(item))
                {
                    PrimeNumbers.Add(item);
                }
                else
                {
                    NonPrimeNumbers.Add(item);
                }
            }
            #endregion

            #region Listeleri önce küçükten büyüğe sıralayıp, sonra da ters çevirerek büyükten küçüğe sıralamış oldum.
            PrimeNumbers.Sort();
            NonPrimeNumbers.Sort();
            PrimeNumbers.Reverse();
            NonPrimeNumbers.Reverse();
            Console.Clear();// Ekran fazla dolmasın diye konsol ekranını temizledim. 
            #endregion

            #region Benden istenen verileri ekrana yazdırdım. 
            Console.WriteLine("************* Asal Sayılar ***********");
            foreach (int item in PrimeNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Girdiğiniz sayılar arasındaki asal olan sayılar {PrimeNumbers.Count} tanedir. Bu sayıların ortalaması: {Average(PrimeNumbers)}\n");
            Console.WriteLine("************* Asal Olmayan Sayılar ***********");

            foreach (int item in NonPrimeNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Girdiğiniz sayılar arasındaki asal Sayılar {NonPrimeNumbers.Count} tanedir. Bu sayıların ortalaması: {Average(NonPrimeNumbers)}\n");
            #endregion
        }




        #region Sayının Asal olup olmadığını söyleyen metot 
        static bool IsPrime(int number)
        {
            bool isPrime = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else isPrime = true;

            }
            return isPrime;
        }
        #endregion
        #region Klavyeden girilen değerin bir sayı olup olmadığını kontrol eden metot
        static bool IsNumber(string param)
        {
            int numb;
            bool IsConverted = int.TryParse(param, out numb);
            if (IsConverted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Klavyeden girilen sayıyı integer a çevirerek pozitif bir sayı olup olmadığını kontrol eden metot
        static bool IsPositive(string numberInput)
        {
            bool control = false;
            int number;
            if (IsNumber(numberInput))
            {
                number = int.Parse(numberInput);

                if (number > 0)
                {
                    control = true;
                }
                else
                {
                    control = false;
                }
            }
            return control;
        }
        #endregion
        #region Parametre olarak verilen listelerin elemanlarının ortalamasını alan metot 
        static decimal Average(ArrayList list)
        {
            int toplam = 0;
            foreach (int item in list)
            {
                toplam += item;
            }
            return toplam / list.Count;
        }
        #endregion


    }
}
