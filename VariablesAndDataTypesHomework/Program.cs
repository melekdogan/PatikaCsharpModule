using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 4;
            string degisken = null;
            string Degisken = null;
            string degisken_veri = null;
            Console.WriteLine(deger);

            string degisken1 = " ";
            Console.WriteLine(degisken1=="");// == operatörü eşit mi? sorusunun operatör karşılığıdır. Eşit değilse False değeri döndürecektir. Eşitse de True...
           
            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            //Reel Sayılar 
            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = 'a';
            string str = "Melek"; //sınırsız değer aralığı

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            object ob1 = "M";
            object ob2 = 'X';
            object ob3 = 4;
            object ob4 = 4.3;
            object ob5 = new MyClass(); //Bunu merak ettiğim için denedim. Object tipindeki bir değişkene bir sınıf nesnesi atanabiliyormuş, bunu öğrendim. 


            string str1 = string.Empty;
            str1 = "Melek Doğan";
            string ad = "Melek";
            string soyad = "Doğan";
            string tamAd = ad + " " + soyad;

            int i1 =2;
            int i2 = 5;
            int i3 = i1 + i2;

            bool boolean1 = true; //varsayılan verisi false gelir. 

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + int.Parse(str20);

            int int22 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int22);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

         Console.ReadKey();
        }
    }
    class MyClass
    {
        public int MyProperty { get; set; } // otomatik property (özellik) tanımı -- prop + 2 kez tab tuşu 
    }
}
