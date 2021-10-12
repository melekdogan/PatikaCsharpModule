using System;

namespace Koleksiyonlar_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            //(Array sınıfını kullanarak yazınız.)
            int[] numbers = new int[20];
            int[] smallest = new int[3];
            int[] largest = new int[3];
            decimal averageOfLargestNumbers ;
            decimal averageOfSmallestNumbers;
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i+1}. Sayıyı Girin: ");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);//Küçükten büyüğe sıralandı
            
            for(int i = 0; i < smallest.Length; i++)
            {
                smallest[i] = numbers[i];
            }
            Array.Reverse(numbers); // Ters çevrilerek büyükten küçüğe sıralanmış oldu. Çünkü önceki satırlarda zaten küçükten büyüğe sıralanmıştı.
            for (int i = 0; i < largest.Length; i++)
            {
                largest[i] = numbers[i];
            }
            averageOfLargestNumbers = Average(largest);
            averageOfSmallestNumbers = Average(smallest);

            Console.WriteLine($"En büyük 3 sayının ortalaması: {averageOfLargestNumbers}");
            Console.WriteLine($"En Küçük 3 sayının ortalaması: {averageOfSmallestNumbers}");
            Console.WriteLine($"Bu Ortalamaların toplamı {averageOfSmallestNumbers+averageOfLargestNumbers}");
        }
        static decimal Average(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            
            }
            return (sum / arr.Length);
        }
    }
}
