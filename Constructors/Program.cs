using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe", "Kara",1232323,"İnsan Kaynakları");          
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****************************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 129382389;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
            Console.WriteLine("*****************************");
            Calisan calisan3 = new Calisan("Ayşe", "Karaduman");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;



        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}");
            Console.WriteLine($"Çalışan Soyadı: {Soyad}");
            Console.WriteLine($"Çalışan Numarası: {No}");
            Console.WriteLine($"Çalışan Departmanı: {Departman}");
        }
    }
}
