using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y + 3;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);



            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess&&isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess||isCompleted)
            {
                Console.WriteLine("Great!");
            }
            if (isSuccess&& !isCompleted)
            {
                Console.WriteLine("Fine!");
            }


            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a>= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("***** Aritmetik Operatörler *****");


            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 ++ ;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

            Console.ReadKey(); // Açılan konsol ekranının hemen kapanmaması için kullanıcıdan bir tuşa basmasını bekleyen komutu yazdım. Herhangi bir tuşa basılmadığı sürece kapanmaz.

        }
    }
}
