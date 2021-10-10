using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDefining
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);

            //Metot Aşırı yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Melek", "Doğan");
            Console.ReadKey();
        }


       
    }

    class Metotlar
    {
        public void Topla(int deger1, int deger2, out int toplam)
        {
            toplam =deger1 + deger2;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 +" "+ veri2);
        }
      
    }
}
