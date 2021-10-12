using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            char[] vowels = { 'a','e','ı','i','u','ü','o','ö'}; //sesli harfler sabit olduğu için, bu harflerin içinde olduğu bir dizi tanımladım. 
            int count = 0;
            string vowelsInInput = "";
            List<char> vowelList = new List<char>();
            Console.WriteLine("bir cümle giriniz:");
            String input = Console.ReadLine().ToLower(); 
           
            for (int i = 0; i < input.Length; i++) 
            {
                for (int k = 0; k < vowels.Length; k++) 
                {
                    if (input[i] == vowels[k]) 
                    {
                        vowelsInInput+=input[i];
                        count++; 
                    }
                }
            }

            for(int i = 0; i < vowelsInInput.Length; i++)
            {
                vowelList.Add(vowelsInInput[i]);
            }

            vowelList.Sort();

            foreach (char item in vowelList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"sesli harf sayısı: {count}"); 
            Console.ReadKey();
        }

    }
    }

